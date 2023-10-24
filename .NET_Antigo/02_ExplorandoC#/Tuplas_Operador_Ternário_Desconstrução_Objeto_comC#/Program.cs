// See https://aka.ms/new-console-template for more information
using Excecoes_Colecoes.models;
using ExemploExplorando.models;
using System.Globalization;
using Tuplas_Operador_Ternário_Desconstrução_Objeto_comNET.models;

// Tupla na Prática

(int, string, string) tupla = (1, "Denerval", "Silva");  // o nome tupla pode ser qualquer nome, sempre lembrar de respeitar a sequencia

System.Console.WriteLine($"Id: {tupla.Item1}");
System.Console.WriteLine($"Nome: {tupla.Item2}");
System.Console.WriteLine($"SobreNome: {tupla.Item3}");

// Outra sintaxe de tupla
System.Console.WriteLine();
ValueTuple<int, string, string> outroExemploTupla = (1, "Denerval", "Silva");
System.Console.WriteLine($"Id: {outroExemploTupla.Item1}");
System.Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
System.Console.WriteLine($"SobreNome: {outroExemploTupla.Item3}");

System.Console.WriteLine();
System.Console.WriteLine("-----------------");

LeituraArquivo arquivo = new LeituraArquivo(); // instanciando arquivo( tipo tupla)

var(sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); // a palavra var identifica automaticamente qual o tipo de variável(tupla no caso) estamos usando(um atalho)
//var(sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");  // usando descarte de infomacao com _ eu posso receber o dado no caso(quantidade de linhas)
                                                                                       // mas caso não queira usar é só no lugar usar um "_"

if(sucesso) 
{
  System.Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
  foreach (string linha in linhasArquivo)
  {
    System.Console.WriteLine(linha);
  }
}
else 
{
  System.Console.WriteLine("Não foi possivel ler o arquivo");
}


System.Console.WriteLine();
System.Console.WriteLine("Usando Desconstructor");

Pessoa p1 = new Pessoa("Dener", "Silva"); // instanciando p1 

(string nome, string sobrenome) = p1;  // usando o desconstrutor jogando os dados nas variaveis nome e sobrenome

System.Console.WriteLine($"{nome}  {sobrenome}");
