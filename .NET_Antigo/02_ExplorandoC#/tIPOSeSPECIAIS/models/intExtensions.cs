using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tIPOSeSPECIAIS.models
{
    public static class intExtensions  // é static  pq não será instanciado
    {
        public static bool EhPar(this int numero) // criando um método do tipo bool é par que recebe como parametro um inteiro 
        {
            return numero % 2 == 0; // e retorna um true se for par e um false se for impar
        }
    }
}