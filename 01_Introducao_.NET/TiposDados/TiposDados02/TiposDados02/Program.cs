// See https://aka.ms/new-console-template for more information
Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();

double n1 = 1.234;
float n2 = 1.234f;
decimal n3 = 1.234m;

decimal n4; // primeiro declarando

n4 = 1.234m; // depois atribui valor

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);

Console.WriteLine("------------------");

Console.WriteLine("Comparando a precisão de float, double e decimal");

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

