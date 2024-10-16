using Sistema_Gerencial_de_Estacionamento.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features
{
    // Classe abstrata para definir comportamento comum
    // Classe para estacionamento de carros, herda de AttributesParking
    internal class CarParking : AttributesParking
    {
        // Construtor que passa o número inicial de vagas para a classe base

        // Implementação do método abstrato para alterar o número de vagas
        public override void AlterarNumeroVagas(int novoNumero)
        {

            Console.WriteLine("\nDigite o novo numero de vagas para o estacionamento de carros/caminhões:");

            if (int.TryParse(Console.ReadLine(), out novoNumero) || novoNumero < 0)
            {
                Console.WriteLine("\nÉ necessário digitar um número, sendo maior que 0. ");
            }
            else
            {
                NumeroVagas = novoNumero;
                Vagas = new List<bool>(new bool[NumeroVagas]); // Redimensiona as vagas
                Console.WriteLine($"\nNúmero de vagas para carros ajustado para: {NumeroVagas}");
            }
        }
    }
}
