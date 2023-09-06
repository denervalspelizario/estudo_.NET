// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arrayInteiros = new int[3];  // criando um array de inteiros de 3 posições

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;


// for tradicional
for (int i = 0; i < arrayInteiros.Length; i++)
{
  Console.WriteLine(arrayInteiros[i]);
}

Console.WriteLine("---------------------------------------- 1");

// for in que é o for of do javascipt que nao pega o indice apenas os dados
foreach(int valoresRecebidos in arrayInteiros){
  Console.WriteLine(valoresRecebidos);
}


Console.WriteLine("---------------------------------------- 2");


// Atualizando o tamanho da array
Array.Resize( ref arrayInteiros, arrayInteiros.Length * 2); // resize(atualiza o valor de um array)  
                                                            // primeiro parametro referencia o array que vai ter seu tamanho alterado 
                                                            // segundo parametro diz o tamanho que ele deve ter no caso do exemplo será o dobro


foreach(int valoresRecebidos in arrayInteiros){
  Console.WriteLine(valoresRecebidos);
}


Console.WriteLine("---------------------------------------- 3");

// Copiando um array para outro
int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];  // criando um array

Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length); // primeiro parametro o array que vou copiar
                                                                        // segundo parametro o array que vai RECEBER a copia
                                                                        // terceiro parametro o tamanho que vai ser

foreach(int valoresRecebidos in arrayInteirosDobrados){
  Console.WriteLine(valoresRecebidos);
}


Console.WriteLine("---------------------------------------- 4");

// Trabalhando com listas

List<string> listaString = new List<string>(); // essa a sintaxe da lista de string

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("MG");
listaString.Add("RJ");


for (int i = 0; i < listaString.Count; i++) // o Count é igual o Lenght
{
  Console.WriteLine($"Posição N {i} - {listaString[i]}");
}

Console.WriteLine();
int posicao = 0;

foreach(string valoresRecebidos in listaString){
  Console.WriteLine($"Posição N {posicao} - {listaString[posicao]}");
  posicao++;
}

// exemplos de metodos usando list

Console.WriteLine($"Itens na minha lista : {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");
Console.WriteLine($"Itens na minha lista : {listaString.Count} - Capacidade: {listaString.Capacity}");
