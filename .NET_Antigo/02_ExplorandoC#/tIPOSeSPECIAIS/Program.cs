// See https://aka.ms/new-console-template for more information
using Excecoes_Colecoes.models;
using ExemploExplorando.models;
using Newtonsoft.Json;
using Nuget_Serializar_atributos.models;
using System.Globalization;
using System.Runtime.Intrinsics;
using tIPOSeSPECIAIS.models;
using Tuplas_Operador_Ternário_Desconstrução_Objeto_comNET.models;


// Tipos Especiais

bool? desejaReceberEmail = true; // o tipo bool só pode receber true ou false mas com o ? pode tb receber o null

if(desejaReceberEmail.HasValue && desejaReceberEmail.Value) // se HasValue(valor diferente de nulo) e Value(o proprio valor dela) ou seja se for diferente de nul e exister algum valor
{
  System.Console.WriteLine("O usuário optou por não receber e-mail");
}
else 
{
  System.Console.WriteLine("O usuário optou por não receber e-mail ou não respondeu");
}

System.Console.WriteLine();
System.Console.WriteLine("3 tipos nulos em propriedades");

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVenda)
{
  System.Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
   $"Desconto: {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
               //HasValue = tem algum valor, ent~ao o ternario fica assim o venda.Desconto tem algum valor ? se tiver (template string) não tem então fiza vazio
}



System.Console.WriteLine();
System.Console.WriteLine("Tipos anonimos");

var tipoAnonimo = new {Nome = "Denerval", Sobrenome = "Slash", Altura = 1.80}; // sintaxe basica tipo anonimo - nome, sobrenome e altura são propriedades anonimas são somente GET assim não podendo altera-las

System.Console.WriteLine("Nome: " + tipoAnonimo.Nome);
System.Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
System.Console.WriteLine("Altura: " + tipoAnonimo.Altura);


System.Console.WriteLine();
System.Console.WriteLine("Tipos anonimos em coleção");



string conteudoArquivo02 = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda02 = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo02);

var listaAnonimo = listaVenda02.Select( x => new {x.Produto, x.Preco}); // com o Select estou selecionando um novo tipo de dado no caso tipos anonimo, 
                                                                       // o x representa um elemento da lista e com ele pegos os dados anonimos que eu quiser no caso o Produto e Preco

foreach (var venda in listaAnonimo)
{
  System.Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");  
}                    

System.Console.WriteLine();
System.Console.WriteLine("Tipo Dinamico");

dynamic variavelDinamica = 4;  // o tipo dinamico muda o tipo de vaiavel de acordo com o valor recebido

System.Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor : {variavelDinamica}");


variavelDinamica = "Texto";  //aqui virou um  tipo string

System.Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor : {variavelDinamica}");

variavelDinamica = true; //aqui virou um  tipo bool

System.Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor : {variavelDinamica}");



System.Console.WriteLine();
System.Console.WriteLine("Classe Genérica");

MeuArray<int> arrayInteiro = new MeuArray<int>(); // classe generica criado la no models MeuArray aqui passamos o seu tipo que neste caso é inteiro


arrayInteiro.AdicionarElementoArray(30);

System.Console.WriteLine(arrayInteiro[0]);


MeuArray<string> arrayString = new MeuArray<string>(); // classe generica criado la no models MeuArray aqui passamos o seu tipo que neste caso é string


arrayString.AdicionarElementoArray("teste string");

System.Console.WriteLine(arrayString[0]);



System.Console.WriteLine();
System.Console.WriteLine("Métodos de Extensão");


int numero = 30;
bool par = false;

par = numero.EhPar();  // numero chamando o metodo EhPar que veirifica se é par ou nao la da classe intExtensions

string mensagem = "O numero " + numero + " " + "é " + (par ? "par" : "impar");

System.Console.WriteLine(mensagem);