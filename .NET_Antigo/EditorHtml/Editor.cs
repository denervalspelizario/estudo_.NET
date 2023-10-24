using System;
using System.Text;

namespace EditorHtml 
{
  public static class Editor
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White; // mudando a cor de fundo
      Console.ForegroundColor = ConsoleColor.Black; // mudando a cor da letra
      Console.Clear(); // limpando o sistema
      Console.WriteLine("MODO EDITOR"); 
      Console.WriteLine("============");
      Start(); // chamando o metodo start
    }
    public static void Start()
    {
      var file = new StringBuilder(); // quando o arquivo tem muitas linhas é interessante usar o stringBuilder  

      do 
      {
        file.Append(Console.ReadLine()); // ele vai LER a linha de dado e jogar dentro de file
        file.Append(Environment.NewLine); // depois de adicionar o dado adiciona uma linha sem dado
      }
      while(Console.ReadKey().Key != ConsoleKey.Escape); // enquanto for digitado algo diferente de ESC o programa continua

      Console.WriteLine("---------------");
      Console.WriteLine(" Deseja salvar o arquivo?");
      Viewr.Show(file.ToString());
    }

  }
}