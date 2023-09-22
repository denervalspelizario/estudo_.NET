using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
  public class Viewr
  {
    public static void Show(string text) // este metodo show vai receber uma string
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White; // mudando a cor de fundo
      Console.ForegroundColor = ConsoleColor.Black; // mudando a cor da letra
      Console.Clear(); // limpando o sistema
      Console.WriteLine("MODO VISUALIZAÇÃO"); 
      Console.WriteLine("------------------");
      Replace(text); // chamando o metodo replace que vai receber o texto digitado
      Console.WriteLine("------------------");
      Console.ReadKey(); // pegando a tecla digitada
      Menu.Show(); // chamando o metodo show
    }

    public static void Replace(string text)
    {
       var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");  // criando uma regex que pega todos dos dados entre um <strong> e </strong> atentar ao @ antes das "" senão da erro 
       var words = text.Split(' '); // pegando os dados de text e tirando os espaços e dividosn as palavras em um array

       for (int i = 0; i < words.Length; i++) // fazendo um loop com o tamanho da palavra 
       {
          if(strong.IsMatch(words[i])) // se a palavra de strong for a mesma que a palavra words[i](ou seja existe essa palavra tanto dentro de strong e words) então                                            
          {                            //  
            Console.ForegroundColor = ConsoleColor.Blue; // alterando a cor da letra con  sole
            Console.Write( 
              words[i].Substring( // usando o metodo do Substring pegando os dados que tiverem do > pra frente por isso > + 1
                words[i].IndexOf('>') + 1,
                (
                  (words[i].LastIndexOf('<') -1) - // e agora acessando a quantidade que vai querer  depos de > + 1, no caso sera o ULTIMO indice < -1 ou seja o ultimo antes de < MENOS
                  words[i].IndexOf('>')            // o primeiro depois de >
                )

              )
            );
            Console.Write(" "); // criando o espaço em uma linha
          } else {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(words[i]);
            Console.Write(" ");
          }
       }
    }
  }
}