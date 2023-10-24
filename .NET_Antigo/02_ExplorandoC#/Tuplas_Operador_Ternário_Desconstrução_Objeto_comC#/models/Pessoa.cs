using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Pessoa
    { 
        // Construtores
        
        public Pessoa(string nome, string sobrenome) // o construtor tem que ter o mesmo nome da classe
        {
            Nome = nome;  // Nome proprieda, nome variavek do parametro
            Sobrenome = sobrenome;
        }
        public Pessoa() // 
        {

        }
        // Criando um Desconstrutor
        public void Deconstruct(out string nome, out string sobrenome) // para fazer o Desconstrutor precisa usar nos parametro a palavra out
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }


        // propriedades ou atributos
        private string _nome; // atributos privados
        private int _idade;
        public string Nome  // atributo publico
        { 
            get => _nome.ToUpper(); // retorna a string que stive em _nome com todos os dados maiusculos
             
            
            set 
            {
                if(value == "") // se o value for vazio, vamos tratar o erro com uma exceção
                {
                    throw new ArgumentException("O nome não pode ser vazio"); // retorna erro e argumenta a "O nome não pode ser vazio"
                }
                
                _nome = value; // depois da validacao adiciona esse value no atributo nome
            }
        }

        public string Sobrenome { get; set; } 
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); 
        public int Idade 
        { 
            get => _idade;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0"); 
                }
                _idade = value;
            }
        }

        // metodos
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} ,Idade: {Idade}");
        }
    }
}