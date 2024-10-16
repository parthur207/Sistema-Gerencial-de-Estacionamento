﻿using Google.Protobuf.WellKnownTypes;
using Sistema_Gerencial_de_Estacionamento.Attributes;
using Sistema_Gerencial_de_Estacionamento.DataBase.Connect_db;
using Sistema_Gerencial_de_Estacionamento.Features;
using Sistema_Gerencial_de_Estacionamento.Features___Execuções;
namespace Sistema_Gerencial_de_Estacionamento.Main
{
    internal class Program 
    {
        public static void Main(string[] args)
        {

            #region Instanciações
            StorageClient aux_C =new StorageClient();

            Connect_db conexao=new Connect_db();

            StorageVehicle aux_V=new StorageVehicle();

            RandomCredential_f aux_R = new RandomCredential_f();
            int numeroVagas=0;
            QueryVenancies_f aux_Q = new QueryVenancies_f(numeroVagas);

            DeleteRecord_f aux_D = new DeleteRecord_f();
            #endregion

            
            int op = 1;
            conexao.Connection();

            while (conexao.validacao_conexao){
                Console.WriteLine("============================================");
                Console.WriteLine("Sistema de Estacionamento");
                Console.WriteLine("============================================");
                Console.WriteLine("1. Registrar Entrada de Veículo/Moto");
                Console.WriteLine("2. Registrar Saída de Veículo/Moto");
                Console.WriteLine("3. Consultar Vagas Disponíveis");
                Console.WriteLine("4. Deletar Registro");
                Console.WriteLine("5. Ver Histórico de Veículos");
                Console.WriteLine("6. Exibir Tarifas");
                Console.WriteLine("7. Relatórios Gerenciais (Admin)");
                Console.WriteLine("8. Configurações do Sistema (Admin)");
                Console.WriteLine("9. Sair");
                Console.WriteLine("============================================");
                Console.WriteLine("Escolha uma opção:");
                while (!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > 9)
                {
                    Console.WriteLine("\nOpção inválida. Digite um digito, sendo de 1 a 9.");
                }
                switch (op)
                {
                    case 1:
                        aux_C.S_Name();
                        
                        aux_V.S_VehicleType();
                        aux_V.S_VehicleName();
                        aux_V.S_VehiclePlate();
                        aux_V.S_VehicleColor(); 

                        aux_C.S_CheckIn();

                        break;

                    case 2:
                        aux_C.S_CheckOut();
                        break;

                    case 3:
                        aux_Q.queryVenancies();
                        break;

                    case 4:
                        
                        break;

                    case 5:
                        //implemento de direicionamento ao método
                        break;

                    case 6:
                        //implemento de direicionamento ao método
                        break;

                    case 7:
                        //implemento de direicionamento ao método
                        break;

                    case 8:

                        conexao.ClosedConnection();

                        //Encerrar conexão com o db

                        //encerrar todas as reservas de veículos.
                        return;
                }

            }
        }
    }
}
