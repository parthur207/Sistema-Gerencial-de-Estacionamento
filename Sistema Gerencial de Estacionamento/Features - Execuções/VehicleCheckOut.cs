using Sistema_Gerencial_de_Estacionamento.Attributes;
using Sistema_Gerencial_de_Estacionamento.IFeatures;
using Sistema_Gerencial_de_Estacionamento.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features
{
    class VehicleCheckOut :AtributesClient, IFeature_Parking
    {
        public void CheckOut()
        {

            bool validacao1=true;
            bool validacao2=true;

            while (validacao1) {
                Console.WriteLine("\nInforme o nome do cliente:");
                string Nome_C = Console.ReadLine().TrimStart().TrimEnd();

                if (string.IsNullOrEmpty(Nome_C))
                {
                    Console.WriteLine("\nO nome do cliente não pode ser nulo.");
                }
                else
                {
                    validacao1 = false;
                }
            }
            while (validacao2) {
                Console.WriteLine("\nDados do cliente e veículo:");
                Console.WriteLine("============================================");


                //Incrementar uma funcionalidade irá realizar a query conforme o nome do cliente, exibir os dados do veículo de vinculação e o check-in de entrada ao estacionamento
               
                
                Console.WriteLine("============================================");
                Console.WriteLine("\nDeseja confirmar o check-out? ");
                Console.WriteLine("\n1. Sim");
                Console.WriteLine("2. Não");
                Console.WriteLine("============================================");
                if(int.TryParse(Console.ReadLine(),  out int op) || op<1 || op>2){
                    Console.WriteLine("\nOpção inválida. Digite (1) para 'Sim' ou (2) para 'Não'.");
                }
                else if (op.Equals(1))
                {
                    validacao2 = false;
                    
                    Saida=DateTime.Now;
                    //Dimensiona para a feature que colhe a data/horário atual referencindo ao encerramento da estadia ao estacionamento e calcula o valor a ser pago
                }
                else if(op.Equals(2))
                {
                    validacao2 = false;

                    Program.Main(ref_args);

                }
            }
        }
    }
}
