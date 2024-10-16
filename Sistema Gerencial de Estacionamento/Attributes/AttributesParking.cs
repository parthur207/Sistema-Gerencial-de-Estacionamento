using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Attributes
{
    internal abstract class AttributesParking
    {
   
        protected int NumeroVagas_C { get; set; }

        protected int NumeroVagas_M { get; set; }

        public List<bool> Vagas_C { get; set; }

        public List<bool> Vagas_M { get; set; }

        public abstract void AlterarNumeroVagas(int novoNumero);

        public abstract void ExibirNumeroVagas();
       
    }
}
