// See https://aka.ms/new-console-template for more information
Console.WriteLine("alunos");



string[] nomes = new string[5]; // array tipo string com 5 valores

double[] notas = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Infomar o nome do aluno");
    string nome = Console.ReadLine(); // recendo o dado digitado

    nomes[i] = nome;  // adicionando o valor passado pelo user ao array nomes
}


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Infomar a nota do aluno");
    // como o dado supostamente vem como string então precisa converter
    double nota = Convert.ToDouble(Console.ReadLine()); // recendo o dado digitado

    notas[i] = nota;
}


foreach (string nome in nomes)
{
    Console.WriteLine($"{nome}");
}


foreach (double nota in notas)
{
    Console.WriteLine($"{nota}");
}

double soma = 0;

foreach (double nota in notas)
{
    soma += nota;
}

double media = soma / notas.Length;

Console.WriteLine($"A media geral foi {media}");
