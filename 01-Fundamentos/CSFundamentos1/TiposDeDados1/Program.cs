// See https://aka.ms/new-console-template for more information
Console.WriteLine("Declarando variáveis numericas");
Console.WriteLine();
Console.WriteLine();


byte valor1 = 255;
sbyte valor2 = -127;
int idade = 30;
float altura = 1.75f;
double salario = 2500.50;
bool temCarro = true;
char letra = 'A';
string nome = "João";
int[] numeros = { 1, 2, 3, 4, 5 };
object objeto = "Este é um objeto";
int? numero = null; // perminte valores nulos

// uma possibilidade tb é fazer declaração do tipo e depois chamar varias variaveis desse mesmo tipo
// exemplo

int var1 = 8, var2 = 9, var3 = 10;  // NÃO SEI SE É MUITO USUAL FAZER ISSO MAS DA PARA FAZER E FUNCIONA


Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(idade);
Console.WriteLine(altura);
Console.WriteLine(salario);
Console.WriteLine(temCarro);
Console.WriteLine(letra);
Console.WriteLine(nome);
Console.WriteLine(numeros[0]);
Console.WriteLine(objeto);
Console.WriteLine(numero);

