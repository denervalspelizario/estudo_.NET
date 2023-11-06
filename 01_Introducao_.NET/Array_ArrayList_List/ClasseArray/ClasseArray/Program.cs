// See https://aka.ms/new-console-template for more information


// Classe de Array

using System.Threading.Channels;

string[] nomes = { "Ana", "Maria", "Dinair", "Paulo", "Carlos", "Beatriz"};

Console.WriteLine("\n\nExibindo o array original...");

foreach (var nome in nomes)
{
    Console.Write($"{nome}  ");
}


Console.WriteLine("\n\nInvertendo a ordem do array...");

// Invertendo os dados de array
Array.Reverse(nomes);

foreach (var nome in nomes)
{
    Console.Write($"{nome}  ");
}


Console.WriteLine("\n\nOrdenando a ordem do array...");

// Ordenando os dados do array

Array.Sort(nomes);

foreach (var nomeItem in nomes)
{
    Console.Write($"{nomeItem}  ");
}



Console.WriteLine("\n\nLocalizando um item do array...");

// Localizando os dados do array

Console.WriteLine("Informe o nome");

string nomeLocalizar = Console.ReadLine(); // recendo dado do usuario

// prrocurando o nomeLocalizar dentro do nomes
var indice = Array.BinarySearch(nomes, nomeLocalizar);

if(indice >= 0)
{
    Console.WriteLine($"\n{nomeLocalizar} foi encontrado com índice = {indice}");
} 
    else
{
    Console.WriteLine($"\n{nomeLocalizar} não foi encontrado");
}

