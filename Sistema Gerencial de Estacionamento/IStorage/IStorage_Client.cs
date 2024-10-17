using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gerencial_de_Estacionamento.IParking
{
    internal interface IStorage_Client
    {
        void S_Name() { }
        void S_CheckIn() { }
        void S_CheckOut() { }
    }
}

