using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Gerencial_de_Estacionamento.DataBase.Connect_db
{
    internal sealed class Connect_db
    {
        public bool validacao_conexao { get; set; }
        private MySqlConnection cnn { get; set; }
        protected string Connection_String { get; private set; } = @"Server=127.0.0.0.1;Port=3306;DataBase= DB; User ID = root; Password=Admin;";

        public string GetConnection()
        {
            return Connection_String;
        }
        public void Connection()
        {
            try
            {
                using (cnn = new MySqlConnection(Connection_String))
                {
                    cnn.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOcorreu um erro inesperado na tentiva de conexão ao banco de dados.\n Erro: {ex.ToString()}");
            }
        }

        public void ClosedConnection()
        {
            try
            {
                using (cnn = new MySqlConnection(Connection_String))
                {
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOcorreu um erro inesperado: {ex.ToString()}");
            }

        }
    }
}
