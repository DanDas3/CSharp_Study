using NUnit.Framework;
using System.Configuration;
using System.Data.SqlClient;

namespace Agenda.DAO.Test
{
    [TestFixture]
    public class BaseTest
    {
        private string _script;
        private string _con;
        private string _catalogTest;

        public BaseTest()
        {
            var conf = ConfigurationManager.OpenExeConfiguration("Contato.DAO.Test.dll");
            var connectiosStrings = conf.ConnectionStrings.ConnectionStrings;

            _script = "AgendaDatabase_Create.sql";
            _con = connectiosStrings["conSetUpTest"].ConnectionString;
            _catalogTest = connectiosStrings["conSetUpTest"].ProviderName;
            _con = GetConnectionStringByOS();
        }

        private string GetConnectionStringByOS()
        {
            string connectionString = "";
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32S:
                    connectionString = GetConnectionStringWithIntegratedSecurity();
                    break;
                case PlatformID.Win32Windows:
                    connectionString = GetConnectionStringWithIntegratedSecurity();
                    break;
                case PlatformID.Win32NT:
                    connectionString = GetConnectionStringWithIntegratedSecurity();
                    break;
                case PlatformID.WinCE:
                    connectionString = GetConnectionStringWithIntegratedSecurity();
                    break;
                case PlatformID.Unix:
                    connectionString = FormatConnectionString(connectionString, EnvironmentVariableTarget.Machine);
                    break;
                case PlatformID.Xbox:
                    connectionString = GetConnectionStringWithIntegratedSecurity();
                    break;
                case PlatformID.MacOSX:
                    connectionString = FormatConnectionString(connectionString, EnvironmentVariableTarget.Machine);
                    break;
                case PlatformID.Other:
                    connectionString = FormatConnectionString(connectionString, EnvironmentVariableTarget.Machine);
                    break;
                default:
                    connectionString = FormatConnectionString(connectionString, EnvironmentVariableTarget.Machine);
                    break;
            }

            return connectionString;
        }

        private string GetConnectionStringWithIntegratedSecurity()
        {
            return @"Data Source = localhost; Initial Catalog = Agenda; Integrated Security = True;";
        }

        private string FormatConnectionString(string connectionString, EnvironmentVariableTarget target)
        {
            connectionString = connectionString.Replace("#SQLUSER",Environment.GetEnvironmentVariable("SQLUSER", target));
            connectionString = connectionString.Replace("#SQLPASS", Environment.GetEnvironmentVariable("SQLPASS",target));

            return connectionString;
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            CreateDBTest();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            DeleteDatabase();
        }

        private void CreateDBTest()
        {
            using (var con = new SqlConnection(_con))
            {
                con.Open();
                var scriptSql = File
                    .ReadAllText($@"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}{_script}")
                    .Replace("$(DefaultDataPath)", $@"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}")
                    .Replace("$(DefaultLogPath)", $@"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}")
                    .Replace("$(DefaultFilePrefix)", _catalogTest)
                    .Replace("$(DatabaseName)", _catalogTest)
                    .Replace("WITH (DATA_COMPRESSION = PAGE)", string.Empty)
                    .Replace("SET NOEXEC ON", String.Empty)
                    .Replace("GO\r\n", "|");
                ExecuteScriptSql(con, scriptSql);
            }
        }

        private void ExecuteScriptSql(SqlConnection con, string scriptSql)
        {
            using (var cmd = con.CreateCommand())
            {
                foreach (var sql in scriptSql.Split("|"))
                {
                    cmd.CommandText = sql;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(sql);
                        Console.WriteLine(e.Message);
                        throw;
                    }
                }
            }
        }

        private void DeleteDatabase()
        {
            using (var con = new SqlConnection(_con))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = $@"USE [master];
                                     Declare @kill varchar(8000) = ''
                                     SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'
                                     FROM sys.dm_exec_sessions
                                     WHERE database_id = db_id('{_catalogTest}')
                                     EXEC(@kill)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $@"DROP DATABASE {_catalogTest}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
