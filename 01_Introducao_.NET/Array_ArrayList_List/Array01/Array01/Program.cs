// See https://aka.ms/new-console-template for more information

// declaração do array
int[] numeros;

// alocando dado na memoria
numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


// array de string
string[] nomes = new string[5] {"Ana", "Maria", "Marta", "Paulo", "Carlos"};

// omitindo tamanho
string[] nomes02 = new string[] { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

// sintaxe reduzida ** mais ultilizada
string[] nomes03 = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

Console.WriteLine(nomes03[0]); // Ana
Console.WriteLine(nomes03[1]); // Maria
Console.WriteLine(nomes03[2]); // Marta
Console.WriteLine(nomes03[3]); // Paulo
Console.WriteLine(nomes03[4]); // Carlos


// declarando um array
int[] numeros04;

// alocar memoria
numeros04 = new int[3];

numeros04[0] = 1;
numeros04[1] = 2;
numeros04[2] = 3;


// percorrendo uma array por for

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {nomes[i]}");
}

// percorrendo com forEach

foreach (var item in nomes)
{
    Console.WriteLine($"Elementos de índice {item}");
}