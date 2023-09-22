using System;

namespace EditorHtml 
{
  public static class Menu
  {
    // Metodos
    public static void Show()
    {
      Console.Clear(); // limpando menu
      Console.BackgroundColor = ConsoleColor.DarkBlue; // metodo que troca cor de fundo do console
      Console.ForegroundColor = ConsoleColor.Blue; // metodo que troa a letra do console
      DrawScreen(); // chamando metodo com estrutura de cor do menu
      WriteOptions(); // chmando metodo com os dados escritos do menu
      
      var option = short.Parse(Console.ReadLine()); // pegando o dado digitado e transfomando em short

      HandleMenuOption(option); // chamando o metodo que faz a açãode acordo com que fgoi digitado 
    }

    public static void DrawScreen()
    {
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
      {
        Console.Write("-");
      }
      Console.Write("+");
      Console.Write("\n");

      for (int lines = 0; lines <= 10; lines++)
      {
        Console.Write("|");
        for (int i = 0; i <= 30; i++)
        {
          Console.Write(" ");
        }
        Console.Write("|");
        Console.Write("\n"); 
      }

      Console.Write("+");
      for (int i = 0; i <= 30; i++)
      {
        Console.Write("-");
      }
      Console.Write("+");
      Console.Write("\n");

    }
  
    public static void WriteOptions()
    {
      Console.SetCursorPosition(3,2); // adiciona o cursor na COLUNA 3 LINHA 2 
      Console.WriteLine("Editor HTML"); // depois de posicionar o cursor adiciona o texto Editor HTML
      Console.SetCursorPosition(3,3); // adiciona o cursor na COLUNA 3 LINHA 3 
      Console.WriteLine("============");
      Console.SetCursorPosition(3,4); // adiciona o cursor na COLUNA 3 LINHA 4 
      Console.WriteLine("Selecione uma opççao abaixo");
      Console.SetCursorPosition(3,6); 
      Console.WriteLine("1 - Novo Arquivo");
      Console.SetCursorPosition(3,7); 
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3,9); 
      Console.WriteLine("0 - Sair");
   
      Console.SetCursorPosition(3,10); 
      Console.Write("Opção ");
    }
  
    public static void HandleMenuOption(short option)
    {
      switch(option){
        case 1: Editor.Show(); break; // se digitar 1 chamará o metodo show
        case 2: Console.WriteLine("View"); break;
        case 0: 
        {
          Console.Clear(); // limpando o console
          Environment.Exit(0); // sai do sistema
          break;
        }
        default: Show(); break; // digitou aolgo diferente das opções volta ao menu 
      } 
    }
  
  }
}