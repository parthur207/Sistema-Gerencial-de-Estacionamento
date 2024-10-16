using Sistema_Gerencial_de_Estacionamento.Attributes;
using Sistema_Gerencial_de_Estacionamento.Features___Execuções;
using Sistema_Gerencial_de_Estacionamento.IFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features
{
    internal class VenanciesCar : CarParking, IFeature_Parking
    {

        public void Exibition_Venancies(Tipo_Veiculo veiculo)
        {

            if (veiculo.Equals(Tipo_Veiculo.Carro) || veiculo.Equals(Tipo_Veiculo.Caminhão)) 
            {
                ExibirNumeroVagas();
            }
            else if (veiculo.Equals(Tipo_Veiculo.Moto))
            {
                ExibirNumeroVagas();
            }
        }
    }
}
