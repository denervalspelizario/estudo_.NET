using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Curso
    {
        // propriedades
        public string Nome { get; set; }
        public List<Pessoa> Alunos {get; set;} // classe Pessoa tipo list chamada Alunos

        // metodos
        public void AdicionarAluno(Pessoa aluno) // esta sintaxe o public é opcional sem ele também funciona                                                 
        {                                        // o paramtro é uma classe(Pessoa) que é uma list  chamada aluno    
          Alunos.Add(aluno);// adicionando a list      
        }
        public int ObterQuantidadeAlunoMatriculados()
        {
            int quantidade = Alunos.Count;  // quantidade de dados na classe list Alunos   
            return quantidade; // retornando a variavel
        }

        public void RemoverAluno(Pessoa aluno) // esta sintaxe o public é opcional sem ele também funciona                                                 
        {                                        // o paramtro é uma classe(Pessoa) que é uma list  chamada aluno    
          Alunos.Remove(aluno);// removendo da list      
        }

        public void ListarAlunos() // metodo que lista alunos do tipo void
        {   
            Console.WriteLine($"Alunos do curso de: {Nome}");  // concatenacao por interpolacao de string
            for (int i = 0; i < Alunos.Count; i++)
            {
                string texto = "Nº - " + (i + 1) + " " + Alunos[i].NomeCompleto; // concatenacao igual o do js
                Console.WriteLine(texto); // imprimindo todos os alunos com nome completo
            }       
        }
    }
}