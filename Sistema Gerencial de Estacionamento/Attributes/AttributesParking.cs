using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Attributes
{
    internal abstract class AttributesParking
    {
   
        protected abstract int NumeroVagas { get; set; }
        protected abstract List<bool> Vagas { get; set; }

        public AttributesParking(int numeroVagas) 
        { 
            NumeroVagas=numeroVagas;
            Vagas = new List<bool>(new bool[NumeroVagas]);
        }
        public virtual void  AlterarNumeroVagas(int novoNumero) { }
        public virtual void ExibirNumeroVagas() { }
       
    }
}
