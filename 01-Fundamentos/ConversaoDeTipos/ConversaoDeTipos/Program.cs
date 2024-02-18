// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conversão de Tipos");
Console.WriteLine();

int varInt = 100; // int 4 bytes
double varDouble = varInt; // convertendo o int para o double   int 4 bytes = 8 bytes

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();  // tranformando a variavel valorInt que é um inteiro em string
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);


// usando metodos para fazer a conversão usando a classe Convert
int vInt = 10;
double vDouble = 5.35;
bool valorBool = true;


Console.WriteLine(Convert.ToString(vInt));// convertendo inteiro para string
Console.WriteLine(Convert.ToDouble(vInt));// convertendo inteiro para double 
Console.WriteLine(Convert.ToString(valorBool)); // convertendo bool para string
Console.WriteLine(Convert.ToInt32(vDouble)); // convertendo double para int


Console.ReadLine();



