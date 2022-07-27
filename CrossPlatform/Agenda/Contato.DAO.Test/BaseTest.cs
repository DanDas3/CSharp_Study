using System.Configuration;
using System.Data.SqlClient;
using NUnit.Framework;
namespace Agenda.DAO.Test;

[TestFixture]
public class BaseTest
{
    private string _script;
    private string _con;
    private string _catalogTest;
    
    public BaseTest()
    {
        _script = @"Agenda.sql";
        _con = @"";
        _catalogTest = "AgendaTest";
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
                .Replace("GO\n", "|");
            ExecuteScriptSql(con,scriptSql);
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