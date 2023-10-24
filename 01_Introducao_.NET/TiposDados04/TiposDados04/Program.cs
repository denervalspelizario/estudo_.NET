// See https://aka.ms/new-console-template for more information
Console.WriteLine("Definindo variaveis do tipo string e object e dynamic");
Console.WriteLine();


string nome = "Curso C#";
String titulo = "Curso C# Essencial";


Console.WriteLine(nome);
Console.WriteLine(titulo);

// Obs varaiveis do tipo sttring NAO são mutáveis para isso se usa StringBuilder

string valor = "isto é uma string";
valor = "isto é uma string alterada";

// StringBuilder
// Quando não sabemos que tipo usar usamos o tipo object ou dynamic
object nota = 10;   // pode -se usar dynamic no lugar de object
object valor01 = 8.55m;
object nome01 = "Maria";
object ativa = true;
object letra = 'A';


Console.WriteLine(nota);
Console.WriteLine(valor01);
Console.WriteLine(nome01);
Console.WriteLine(ativa);
Console.WriteLine(letra);



Console.WriteLine("---------------");

