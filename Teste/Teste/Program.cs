using System;
using System.Data.SqlClient;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Danilo";
            string id = Guid.NewGuid().ToString();
            string nomeRecuperado = string.Empty;

            string stringConexao = @"Data Source = .\MSSQLSERVER02; Initial Catalog = Agenda; Integrated Security = True;";

            SqlConnection conexao = new SqlConnection(stringConexao);
            
            conexao.Open();

            //string sql = string.Format("INSERT INTO Contato (Id, Nome) VALUES ({0}, {1})", id, nome);
            string sql = $"INSERT INTO Contato(Id,Nome)VALUES('{id}', '{nome}')";
            SqlCommand cmd = new SqlCommand(sql,conexao);

            int retorno = cmd.ExecuteNonQuery();
            Console.WriteLine($"Numero de linhas afetadas: {retorno}.");

            sql = $"SELECT NOME FROM Contato WHERE ID='{id}'";

            cmd = new SqlCommand(sql,conexao);

            object ret = cmd.ExecuteScalar();
            nomeRecuperado = ret == null ? string.Empty : ret.ToString();
            Console.WriteLine($"Nome recuperado: {nomeRecuperado}");

            conexao.Close();
        }
    }
}
