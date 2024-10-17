﻿using Sistema_Gerencial_de_Estacionamento.Features;
using Sistema_Gerencial_de_Estacionamento.IFeatures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.Features___Execuções
{
    internal class FinalValue: VehicleCheckOut, IFeature_Parking
    {
        protected static double Preco_Minuto { get; set; } = 0.10;

        
        public double Pagamento(TimeSpan Periodo) 
        {
            // Calculo padrão do valor a ser pago: VALOR A PAGAR = (0.10 * minutos)
            if (Periodo.TotalMinutes >= 480) //480 minutos, equivalente a 8 horas
            {
                Preco = 50.00;
            }
            else
            {
                Preco = Preco_Minuto * Periodo.TotalMinutes;
            }
            return Preco; 
        }
    }
}
