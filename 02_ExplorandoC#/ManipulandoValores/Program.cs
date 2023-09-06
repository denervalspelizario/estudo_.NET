// See https://aka.ms/new-console-template for more information
using ExemploExplorando.models;
using System.Globalization;

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // comando para mudar a localizacao do sistema para os eua assim la em baixo será dolar ao invez de brl(real)
// Pessoa p1 = new Pessoa(); // instanciando a classe pessoa a p1

// p1.Idade = 36;
// p1.Nome = "Dener";
// p1.Sobrenome = "Silva";
// p1.Apresentar();

Pessoa p1 = new Pessoa("Denerval", "Pelizario"); // instanciando a classe pessoa a p1

Pessoa p2 = new Pessoa(nome: "Tom", sobrenome: "Pelizario"); // instanciando a classe pessoa a p2, esse nome:, sobrenome: é opcional são o parametro dos construtores

Curso cursoDeIngles = new Curso(); // criando uma variavel(cursoDeIngles) que recebe a classe Curso
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>(); // instanciando em alunos a classe list Pessoa

cursoDeIngles.AdicionarAluno(p1); // adicionano a list curso de ingles p1
cursoDeIngles.AdicionarAluno(p2); // adicionano a list curso de ingles p2
cursoDeIngles.ListarAlunos();

Console.WriteLine("-------------------------");
decimal valorMonetario = 1582.40M; // tipo decimal precisa colocar o M no final senão não reconhece
string numero02 = "20";

// formatando  o valorf em real
Console.WriteLine($"{valorMonetario:C}"); // esse :C vai fazer com que o resultado R$ 1.582,40   - ele pega a localizacao do seu sistema e converte para moeda local

// formatando o valor em dolar
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //mudando a localizacao apenas para esta opcao no caso para localizacao em us que retorna em dolar

// representando a formatacao em apenas 1 casa depois da virgula
Console.WriteLine(valorMonetario.ToString("C1")); // R$ 1.582,4
// 3 casas depois da virgula
Console.WriteLine(valorMonetario.ToString("C3")); // R$ 1.582,400

Console.WriteLine(); 

// representando porcentagem
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P")); // 34,21%
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##")); // 12-34-56
Console.WriteLine(); 

// Trabalhar com datas date

DateTime data = DateTime.Now; // pegando a data de agora
Console.WriteLine(data); // 06/09/2023 15:27:04

// personalizando data
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // 06/09/2023 15:29
Console.WriteLine(data.ToShortDateString()); // 06/09/2023
Console.WriteLine(data.ToShortTimeString()); // 16:06

DateTime dataPersonalizado = DateTime.Parse("05/09/2022 18:00"); // passando data personalizada
Console.WriteLine(dataPersonalizado); // 05/09/2022 18:00:00

Console.WriteLine(); 

string dataString = "2024-04-17 18:00";

// garatindo que será repassado um data correta, 1 parametro data passada, 2 parametro estrutura da data, 3 parametro a cultura no caso sem cultura definida
// 4 parametro o estilo de data que no caso será none e 5 parametro  dado que será a saida
DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataTry);

Console.WriteLine(dataTry); // 17/04/2024 18:00:00
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataTry02);
if(sucesso)
{
  Console.WriteLine($"Conversão com sucesso! Data: {dataTry02}");
}
else 
{
  Console.WriteLine($"{dataTry02} não é uma data válida");
}

DateTime dataPersonalizadoString = DateTime.Parse(dataString); // passando data personalizada
Console.WriteLine(dataPersonalizadoString); // 17/04/2024 18:00:00




