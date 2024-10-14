using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Gerencial_de_Estacionamento.DataBase.Connect_db
{
    internal class Connect_db
    {

        public  MySqlConnection cnn { get; private set; }
        protected string Connection_String { get; private set; } = @"Server=127.0.0.0.1;Port=3306;DataBase=Boletos DB; User ID = root; Password=Admin;";

        protected void Connection()
        {
            try
            {
                using (cnn = new MySqlConnection())
                {
                    cnn.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOcorreu um erro inesperado na tentiva de conexão ao banco de dados.\n Erro: {ex.ToString()}");
            }
        }
    }
}
