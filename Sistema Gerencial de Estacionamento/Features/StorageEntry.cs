using Sistema_Gerencial_de_Estacionamento.Attributes;
using Sistema_Gerencial_de_Estacionamento.IParking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features
{
    internal class StorageEntry : AtributtesClient, IStorage_Client
    {

        public void S_Name() 
        {
            bool aux1 = true;
            while (aux1)
            {
                Console.WriteLine("\nDigite o nome do cliente:");
                Nome = Console.ReadLine().TrimStart().TrimEnd();

                if (string.IsNullOrEmpty(Nome))
                {
                    Console.WriteLine("\nO nome do cliente não pode ser nulo.");
                }
                else
                {
                    aux1 = false;
                    //Incremento de repasse do dado colhido
                }
            }
        }

        public void S_Entry() 
        {
            Entrada = DateTime.Now;

            //Incremento de repasse do dado colhido
        }
    }
}
