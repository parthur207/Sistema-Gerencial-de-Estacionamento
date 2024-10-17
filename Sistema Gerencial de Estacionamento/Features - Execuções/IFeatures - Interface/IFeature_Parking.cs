using Sistema_Gerencial_de_Estacionamento.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features___Execuções.IFeatures___Interface
{
    internal interface IFeature_Parking
    {
        TimeSpan CheckOut_periodo(DateTime Entrada, DateTime Saida) 
        {
            return TimeSpan.Zero;
        }
        void queryVenancies() { }
        void Exibition_Venancies(Tipo_Veiculo veiculo) { }
        string C_Radom() { return string.Empty; }
        double Calculo_Pagamento(TimeSpan Periodo) { return 0; }
        void Delete_R() { }
    }
}
