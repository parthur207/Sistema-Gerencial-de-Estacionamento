using Sistema_Gerencial_de_Estacionamento.Features;
using Sistema_Gerencial_de_Estacionamento.IFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Sistema_Gerencial_de_Estacionamento.Features___Execuções
{
    internal class RandomCredential : StorageClient, IFeature_Parking
    {
        public string C_Radom()
        {
            string Credencial=string.Empty;
            bool LoopRandom = true;

            while (LoopRandom) {

                Random Letter = new Random();

                for (int i = 0; i < 3; i++)
                {
                    char letraAleatoria = (char)Letter.Next(65, 91);//ASCII
                    Credencial+= letraAleatoria.ToString();
                }

                Random Number = new Random();

                for (int i = 3; i < Credencial.Length; i++)
                {
                    int numeroAleatorio = Number.Next(0, 10);// 0 A 9
                    Credencial+= numeroAleatorio.ToString();
                }

                //Incremento de método que irá verificar se ja existe alguma credencial parecida com a gerada, se sim, será realizado uma nova
                if ()
                {

                }
                else 
                {
                    LoopRandom = false;
                }
            }
            return Credencial;
        }
    }
}
    