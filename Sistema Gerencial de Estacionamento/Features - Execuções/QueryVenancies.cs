using Sistema_Gerencial_de_Estacionamento.Attributes;
using Sistema_Gerencial_de_Estacionamento.DataBase.Interface;
using Sistema_Gerencial_de_Estacionamento.Features;
using Sistema_Gerencial_de_Estacionamento.IFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features___Execuções
{
    internal class QueryVenancies : CarParking, IFeature_Parking
    {
        public QueryVenancies(int numeroVagas) :base(numeroVagas) { }

    
        
    }
}
