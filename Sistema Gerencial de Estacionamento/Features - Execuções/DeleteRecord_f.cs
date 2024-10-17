using Sistema_Gerencial_de_Estacionamento.IFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features___Execuções
{
    internal class DeleteRecord_f: IFeature_Parking
    {
        
        public void Delete_R()
        {
            Console.WriteLine("\nDigite a credencial do cliente específico que deseja realizar a exclusão:");
            string Credencial_Delete = Console.ReadLine().ToUpper().Trim();

            if (string.IsNullOrEmpty(Credencial_Delete) || Credencial_Delete.Length > 6)
            {
                Console.WriteLine("\nO valor informado não pode ser branco e deve possuir 6 caracteres, sendo 3 números e 3 letras. ");
            }
            else if (!char.IsLetter(Credencial_Delete[0]) || !char.IsLetter(Credencial_Delete[1]) || !char.IsLetter(Credencial_Delete[2]) || !char.IsNumber(Credencial_Delete[3]) || !char.IsNumber(Credencial_Delete[4]) || !char.IsNumber(Credencial_Delete[5]))
            {
                Console.WriteLine("\nO padrão da credencial está incorreto. A credencial deve possuir 3 letras e 3 números. Credencial exemplar: 'ABC123'");
            }
            else
            {
                DeleteRecord_EF.DeleteRecord();
            }

           

        }
    }
}
