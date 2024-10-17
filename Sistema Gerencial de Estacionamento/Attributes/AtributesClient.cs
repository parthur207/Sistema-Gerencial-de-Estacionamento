using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Attributes
{
    internal class AtributesClient : AtributesVehicle
    {
        public static string[] ref_args { get; private set; }//Parâmetro de referência ao método Main

        protected string Credencial_Acesso {  get; set; }
        protected string Nome { get; set; }
        protected DateTime Entrada { get; set; }
        protected DateTime Saida { get; set; }
        protected TimeSpan PeriodoEstadia { get; set; }
        
        protected double Preco {  get; set; }
    }
}
