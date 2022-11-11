using Conexao;
using MySql.Data.MySqlClient;
using System;
using System.Globalization;

namespace C_

{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriada { get; set; }
    }
    public class Teste
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            var data = new DateTime(2008, 5, 1);
            List<User> users = new List<User>
            {
                new User {Id=1, Nome="Well",    DataCriada=dateTime},
                new User {Id=2, Nome="Luan",    DataCriada=dateTime},
                new User {Id=3, Nome="Luã",     DataCriada=dateTime},
                new User {Id=4, Nome="João",    DataCriada=dateTime},
                new User {Id=5, Nome="Augusto", DataCriada=dateTime},
                new User {Id=6, Nome="Cláudio", DataCriada=dateTime},
                new User {Id=7, Nome="Gabriela",DataCriada=dateTime},
                new User {Id=8, Nome="Joyce",   DataCriada=dateTime},
                new User {Id=9, Nome="Mitchel", DataCriada=dateTime},
                new User {Id=10,Nome="Luiz",    DataCriada=dateTime}
            };

            CriarConexao database = new CriarConexao();
            foreach (var user in users)
            {
                database.saveUsers(user.Nome, user.DataCriada);
            }
        }
    }
}