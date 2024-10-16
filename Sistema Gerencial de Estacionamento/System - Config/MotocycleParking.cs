using Sistema_Gerencial_de_Estacionamento.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features___Execuções
{
    internal class MotocycleParking : AttributesParking
    {
        // Construtor que passa o número inicial de vagas para a classe base
        public AttributesParking(int numeroVagas) : base(numeroVagas) { }

        // Implementação do método abstrato para alterar o número de vagas
        public override void AlterarNumeroVagas(int novoNumero)
        {
                Console.WriteLine("\nDigite o novo numero de vagas para o estacionamento de motos:");
                if(int.TryParse(Console.ReadLine(), out novoNumero) || novoNumero<0)
                {
                    Console.WriteLine("\nÉ necessário digitar um número, sendo maior que 0.");
                }
                else
                {
                    NumeroVagas = novoNumero;
                    Vagas = new List<bool>(new bool[NumeroVagas]); // Redimensiona as vagas
                    Console.WriteLine($"Número de vagas para motos ajustado para: {NumeroVagas}");
                }
            }
         
        }
    }

