// See https://aka.ms/new-console-template for more information
Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();


// double, float e decimal precisam de sufixos no final respectivamente  d, f e m

double n1 = 1.234d;
float n2 = 1.124F;
decimal n3 = 1.234m;


Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine();
// Comparando a precisão de double, float e decimal


float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine("Comparando a precisão de double, float e decimal");
Console.WriteLine();
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
