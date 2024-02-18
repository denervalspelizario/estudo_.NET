// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Entrada de Dados");

Console.WriteLine("\nInforme o seu nome");

string nome = Console.ReadLine(); // recebendo o dado digitado

Console.WriteLine("\nInfoem a sua idade");

int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nO seu nome é " + nome); // imprimindo atravez de uma concatenação 

Console.WriteLine($"\nA sua idade é {idade}");

Console.ReadKey();