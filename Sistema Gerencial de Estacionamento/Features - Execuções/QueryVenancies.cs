using Sistema_Gerencial_de_Estacionamento.Attributes;
using Sistema_Gerencial_de_Estacionamento.DataBase.Interface;
using Sistema_Gerencial_de_Estacionamento.Features;
using Sistema_Gerencial_de_Estacionamento.IFeatures;
using Sistema_Gerencial_de_Estacionamento.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features___Execuções
{
    internal class QueryVenancies : CarParking, IFeature_Parking
    {
        public QueryVenancies(int numeroVagas) :base(numeroVagas) { }

        public void queryVenancies() 
        {
            Console.WriteLine("\nSelecione um opção numérica:");
            Console.WriteLine("\n1. Exibir todos os clientes que estão estacionados no momento.");
            Console.WriteLine("2. Exibir todos os clientes portadores de carros/caminhões estacionados.");
            Console.WriteLine("3. Exibir todos os clientes portadores de motos estacionados");
            if(!int.TryParse(Console.ReadLine(), out int opcao ) || opcao<1 || opcao>3){
                Console.WriteLine("\nOpção inválida. Digite um numeral, sendo de 1 a 3.");
            }
            else if(opcao.Equals(1))
            {
                //Chamada da query dos estacionados no momento. Status true na lista
            }
            else if (opcao.Equals(2))
            {
                //Chamada da query somente dos estacionados do tipo Carro/caminhão
            }
            else if (opcao.Equals(3))
            {
                //Chamada da query somente dos estacionados do tipo Moto
            }
            Program.Main(AtributesClient.ref_args);
        }


    }
}
