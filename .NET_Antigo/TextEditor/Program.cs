// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.IO;
using System.Security.AccessControl;

Menu(); // chamando o metodo menu

// metodo menu
static void Menu(){
  Console.Clear(); // limpando o menu
  Console.WriteLine("O que você deseja fazer?");
  Console.WriteLine("1 - Abrir um arquivo");
  Console.WriteLine("2 - Criar novo arquivo");
  Console.WriteLine("0 - Sair");
  short option = short.Parse(Console.ReadLine()); // option tipo short recebe a leitura(Readline) tranformada em short - recebe o dado digitado na escoha do menu

  switch(option) 
  {
    case 0: System.Environment.Exit(0); break; // se escolher o 0 encerra a aplicação
    case 1: Open(); break; // se escolher 1 chama o metodo open
    case 2: Edition(); break; // se escolher 2 chama o metodo edition
    default: Menu(); break; // escolhendo outra opção chama novamente o Menu

  }
}

// abrindo um arquivo
static void Open(){
  Console.Clear();
  Console.WriteLine("Qual o caminho do arquivo?");
  var path = Console.ReadLine(); // recebendo os dados do caminho e jogando em path

  
  using(var file = new StreamReader(path)) // using serve para abrir e fechar objetos ou arquivos automaticamente, o StreamReader significa um fluxo de leitura(ira ler um arquivo)
  {
      string text = file.ReadToEnd(); // irá ler até o final
      Console.WriteLine(text); // depois de ler irá escrever na tela o conetudo de text que é a leitura do arquivo 
  }
  Console.WriteLine(); // pulando uma linha 
  Console.ReadLine();
  Menu();// voltando ao menu
};

// editando e salvando arquivo
static void Edition()
{
  Console.Clear();
  Console.WriteLine("Digite seu texto abaixo(ESC para sair)");
  Console.WriteLine("------------------");

  string text = ""; // criando uma string vazia

  do
  {
    text += Console.ReadLine(); // adicionando o que foi digitado a variavel text
    text += Environment.NewLine; // adicionando uma linha de espaço ou seja ele recebe o dado digitado e depois uma linha vazia
  }
  while(Console.ReadKey().Key != ConsoleKey.Escape); // se a tecla digitada for diferente de KEY(ESC)  ele vai continuar na repetição
  
  Salvar(text);
};

static void Salvar(string text)
{
  Console.Clear();
  Console.WriteLine("Qual o caminho para salvar o arquivo?");

  var path = Console.ReadLine(); // path recebe o caminho  digitado - obs o var significa que vc esta deixando para o sistema tipar a variavel

  using(var file = new StreamWriter(path)) // using serve para abrir e fechar objetos ou arquivos automaticamente, o StreamWriter significa um fluxo de escrita
  {
      file.Write(text); // no caminho(file) será escrito o text
  }

  Console.WriteLine($"Arquivo {path} salvo com sucesso!");
  Console.ReadLine();
  Menu();

}

