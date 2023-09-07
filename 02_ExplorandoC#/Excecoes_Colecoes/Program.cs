// See https://aka.ms/new-console-template for more information
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


