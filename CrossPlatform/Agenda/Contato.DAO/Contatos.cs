using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Agenda.DAO
{
    public class Contatos
    {
        private string connectionString;
        private SqlConnection connection;

        public Contatos()
        {
            connectionString = @"Data Source = .\MSSQLSERVER02; Initial Catalog = Agenda; Integrated Security = True;";
            connection = new SqlConnection(connectionString);
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
