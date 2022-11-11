using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexao
{
    internal class CriarConexao
    {
        public void saveUsers(string Nome, DateTime DataDeCriacao)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=phpmyadmin;user id=root;pwd=;sslmode=none;");
            string sqlQuery = "INSERT INTO users (Nome, DataCriacao) Values('" + Nome + "', '" + DataDeCriacao + "')";
            MySqlCommand command = new MySqlCommand(sqlQuery);
            command.Connection = conn;

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }

        }
    }
}
