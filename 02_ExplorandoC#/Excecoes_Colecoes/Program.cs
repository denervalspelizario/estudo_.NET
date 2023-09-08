// See https://aka.ms/new-console-template for more information
using Excecoes_Colecoes.models;
using ExemploExplorando.models;
using System.Globalization;

Console.WriteLine("OLA MUNDO");
try // deu certo
{
  // Caminho do arquivo
  string caminhoDoArquivo = "Arquivos/arquivoLeitura.txt";

  // Lê todas as linhas do arquivo
  string[] linhas = File.ReadAllLines(caminhoDoArquivo); // lendo arquivo de leitura

  // Itera e imprime as linhas
  foreach (string linha in linhas)
  {
    Console.WriteLine(linha);
  }
}
catch(FileNotFoundException nomeDaException) // deu erro e nomeei o erro com nome de nomeDaException para tratar de forma mais maigal a menssagem de erro
{
  Console.WriteLine($"Ocorreu na leitura do arquivo.Arquivo não encontrado {nomeDaException.Message}"); // estou acessando o erro e chamando o metodo Message que diz qual o erro
}
catch(DirectoryNotFoundException nomeDaException) // deu erro e nomeei o erro com nome de nomeDaException para tratar de forma mais maigal a menssagem de erro
{
  Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado {nomeDaException.Message}"); // estou acessando o erro e chamando o metodo Message que diz qual o erro
}
catch(Exception nomeDaException) // deu erro e nomeei o erro com nome de nomeDaException para tratar de forma mais maigal a menssagem de erro
{
  Console.WriteLine($"Ocorreu uma exceção genérica. {nomeDaException.Message}"); // estou acessando o erro e chamando o metodo Message que diz qual o erro
}
finally // o finally será sempre executado independente se houve erro ou não
{
  Console.WriteLine("Chegou até aqui");
}

Console.WriteLine();

new ExemploExcecao().Metodo01(); // chamando o metodo 1 da classe ExemploExcecao

Console.WriteLine();
Console.WriteLine("Trabalhando com fila");

// Trabalhando com fila

Queue<int> fila = new Queue<int>(); // criando uma fila do tipo inteiro

fila.Enqueue(2); // adicionando a fila o numero 2
fila.Enqueue(4); // adicionando a fila o numero 4
fila.Enqueue(6); // adicionando a fila o numero 6
fila.Enqueue(8); // adicionando a fila o numero 8

foreach (int item in fila)
{
  Console.WriteLine(item);
}

// na fila não da pra excluir na ordem que vc deseja tem que excluir sempre o PRIMEIRO elemento da fila neste caso vai remover o 2 que foi o PRIMEIRO a ser adicionado
Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10); // adicionando a fila (obs será adicionando por ultimo)
foreach (int item in fila)
{
  Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("Trabalhando com Pilhas");

// Trabalhando com Pilhas 
Stack<int> pilha = new Stack<int>(); // criando uma pilha do tipo inteiro

pilha.Push(2); // adicionando a pilha o numero 2
pilha.Push(4); // adicionando a pilha o numero 4
pilha.Push(6); // adicionando a pilha o numero 6
pilha.Push(8); // adicionando a pilha o numero 8

foreach (int item in pilha)
{
  Console.WriteLine(item);
}

// na pilha não da pra excluir na ordem que vc deseja tem que excluir sempre o PRIMEIRO elemento da pilha neste caso vai remover o 2 que foi o PRIMEIRO a ser adicionado
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
pilha.Push(10); // adicionando a pilha (obs será adicionando no incio(topo))
foreach (int item in pilha)
{
  Console.WriteLine(item);
}


Console.WriteLine();
Console.WriteLine("Trabalhando com Dictionary");

// dictionary é uma coleção de dados
Dictionary<string, string> estados = new Dictionary<string, string>(); // criando um Dictionary com a chave tipo string e meu dado tipo string também
estados.Add("SP", "São Paulo"); // estou adicionando a chave SP que será representado pelo valor "São Paulo"
estados.Add("BA", "Bahia"); 
estados.Add("MG", "Minas Gerais"); 