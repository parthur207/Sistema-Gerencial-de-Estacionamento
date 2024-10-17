using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Gerencial_de_Estacionamento.DataBase.Features___EF
{
    internal interface I_EF
    {
        void DeleteRecord_ef(string Credencial_dlt) { }
        void FullRecords_Query_ef() { }
        void Motos_Query_ef() { }
        void CC_Query_ef() { }
        void UpdateDate_ef() { }
        void CreateNewRecord_ef() { }
    }
}
