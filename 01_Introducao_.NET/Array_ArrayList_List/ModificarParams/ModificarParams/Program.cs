// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nSoma de números inteiros\n");


int[] valores = { 1, 2, 3, 4, 5 }; // array de inteiros 


// resultado recebe  metodo Soma com parametro valores
var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

var resultado02 = Calcular.Soma(1 ,2 ,3 , 4, 5);
Console.WriteLine(resultado02);


Console.ReadKey();


// Classe calcular
public class Calcular
{

    // metodo Somar
    public static int Soma(params int[] numeros) // recebe array de numeros não definido tamanho
    {
        int total = 0; 

        foreach (var numero in numeros) 
        {
            total += numero;
        }
        return total;
    }
}
