using Sistema_Gerencial_de_Estacionamento.Attributes;
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
        protected TimeSpan PeriodoEstadia { get; private  set; }
        public  TimeSpan CheckOut(DateTime Inicio, DateTime Final)
        {
            return PeriodoEstadia;
        }
    }
}
