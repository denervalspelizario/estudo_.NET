// See https://aka.ms/new-console-template for more information
Console.WriteLine("Saida de dados: Usando sequncia de scapes");
Console.WriteLine();

/*
 Uma sequência de escape, em linguagens de programação como C#, 
 é uma combinação de caracteres que tem um significado especial 
 quando aparece em uma string ou em outros contextos específicos. 
 Essas sequências são usadas para representar caracteres que de outra forma 
 seriam difíceis de incluir em uma string de texto de forma literal, 
 como quebras de linha, tabulações, 
 aspas duplas dentro de strings delimitadas por aspas duplas, entre outros

Por exemplo, quando você escreve \n em uma string em C#, 
isso é interpretado como uma quebra de linha, 
mesmo que \n não seja exatamente um caractere imprimível. 
Da mesma forma, \t é interpretado como uma tabulação, 
e \" é interpretado como uma aspa dupla dentro de uma string delimitada por aspas duplas.
 */


// Exemplos
string texto = "Esta é a primeira linha.\nEsta é a segunda linha."; // Para representar uma quebra de linha

string texto2 = "Item1\tItem2\tItem3"; // Para representar um caractere de tabulação

string texto3 = "Primeira linha.\rSegunda linha."; // Para representar um retorno de carro (carriage return)

string texto4 = "Ele disse: \"Olá!\""; // Para representar uma aspa dupla dentro de uma string:

string caminho = @"C:\Diretorio\Arquivo.txt"; // Para representar uma barra invertida

Console.WriteLine(texto);
Console.WriteLine(texto2);
Console.WriteLine(texto3);
Console.WriteLine(texto4);
Console.WriteLine(caminho);




Console.ReadLine();
