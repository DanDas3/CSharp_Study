using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace Agenda.DAO
{
    public class Contatos
    {
        private string connectionString;
        private SqlConnection connection;

        public Contatos()
        {
            var conf = ConfigurationManager.OpenExeConfiguration("Contato.DAO.Test.dll");

            connectionString = conf.ConnectionStrings.ConnectionStrings["con"].ConnectionString;
            //connectionString = connectionString.Replace("#SQLUSER",System.Environment.GetEnvironmentVariable("SQLUSER"));
            //connectionString = connectionString.Replace("#SQLPASS", System.Environment.GetEnvironmentVariable("SQLPASS"));
            //connectionString = @"Data Source = localhost; Initial Catalog = Agenda; Integrated Security = True;";

            connectionString = GetConnectionStringByOS(connectionString);

            connection = new SqlConnection(connectionString);
        }

        private string GetConnectionStringByOS(string connectionString)
        {
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
            return @"Data Source = localhost; Initial Catalog = AgendaTest; Integrated Security = True;";
        }

        private string FormatConnectionString(string connectionString, EnvironmentVariableTarget target)
        {
            connectionString = connectionString.Replace("#SQLUSER", System.Environment.GetEnvironmentVariable("SQLUSER", target));
            connectionString = connectionString.Replace("#SQLPASS", System.Environment.GetEnvironmentVariable("SQLPASS", target));

            return connectionString;
        }

        public int Inserir(Contato contato)
        {
            string sql = $"INSERT INTO CONTATO (ID, NOME) VALUES ('{contato.Id}', '{contato.Nome}')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            int ret = cmd.ExecuteNonQuery();
            connection.Close();
            return ret;
        }

        public Contato Obter(string id)
        {
            string sql = $"SELECT ID, NOME FROM CONTATO WHERE ID = '{id}'";

            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            var sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();
            Contato contato = new Contato()
            {
                Id = Guid.Parse(sqlDataReader["ID"].ToString()),
                Nome = sqlDataReader["NOME"].ToString(),
            };
            return contato;
        }

        public List<Contato> Listar()
        {
            List<Contato> lista = new List<Contato>();
            string sql = $"SELECT ID, NOME FROM CONTATO";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lista.Add(new Contato()
                {
                    Id = Guid.Parse(sqlDataReader["ID"].ToString()),
                    Nome = sqlDataReader["NOME"].ToString()
                });
            }

            return lista;
        }
    }
}
