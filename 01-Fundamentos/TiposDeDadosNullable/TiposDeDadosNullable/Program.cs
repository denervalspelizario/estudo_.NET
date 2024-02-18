// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tipos Nullable");

Nullable<int> i = null;
Nullable<double> o = null;
Nullable<bool> u = null;

// existe uma forma melhor e mais inxuta para dizer que uma variavel é null usando ?

int? a = null;      // exemplo de null de forma simplificada com ?
double? b = null;

// toda variavel null tem que ser tipada ou com ? ou com Nullable
// se não for tipada assim da erro vamos simular um erro

//int? c = null;
//int d = c;   /// vai dar erro pq ? pq a variavel d não foi tipada como null então
             // vc tem que tipa-la senão dá erro

int? e = 100;

if(e.HasValue)
{
    Console.WriteLine($" e = 100");
}
else
{
    Console.WriteLine($"e é null");
}