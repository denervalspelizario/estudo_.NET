using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_Identacao.models
{
    public class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }


        // Métodos  
        public void Apresentar(){
            //Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
            Console.WriteLine($"Olá, meu nome é {Nome},\n e tenho {Idade} anos");
        }   
    }
}