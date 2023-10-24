// See https://aka.ms/new-console-template for more information
using Excecoes_Colecoes.models;
using ExemploExplorando.models;
using Newtonsoft.Json;
using Nuget_Serializar_atributos.models;
using System.Globalization;
using System.Runtime.Intrinsics;
using Tuplas_Operador_Ternário_Desconstrução_Objeto_comNET.models;

// para instalar a biblioteca que tranforma c# em json  dotnet add package Newtonsoft.Json 

DateTime dataAtual = DateTime.Now; // criando uma data chamanda dataAtual com momento de agora

List<Vendas> listaVendas = new List<Vendas>();  // criando uma lista de vendas camada de listaVendas

Vendas v1 = new Vendas(1, "Material de escritorio", 25.00M, dataAtual);

Vendas v2 = new Vendas(2, "Liçença de software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);


string serializando = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); // transformando os dados da lista listaVendas em json e repassando para variavel serializando

System.Console.WriteLine(serializando);

File.WriteAllText("Arquivos/vendas.json", serializando); // usando o metodo WriteAllText do File criando um arquivo chamado vendas.json com conteudo de serializando


System.Console.WriteLine();
System.Console.WriteLine("Deserializando");

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVenda)
{
  System.Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}