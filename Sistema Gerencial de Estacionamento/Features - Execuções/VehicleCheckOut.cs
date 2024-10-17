using Sistema_Gerencial_de_Estacionamento.Attributes;
using Sistema_Gerencial_de_Estacionamento.Features___Execuções;
using Sistema_Gerencial_de_Estacionamento.IFeatures;
using Sistema_Gerencial_de_Estacionamento.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features
{
    class VehicleCheckOut : StorageClient, IFeature_Parking
    {
       
        public TimeSpan CheckOut_periodo(DateTime Entrada, DateTime Saida)
        {

            PeriodoEstadia = Saida - Entrada;
            return PeriodoEstadia;
        }


    }
}
