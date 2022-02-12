using System;
using System.Text.RegularExpressions;

namespace HtmlEditor
{
    public class Viewer{
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Visualização");
            Console.WriteLine("------------------");
            Replace(text);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var word = text.Split(' ');

            for (var i = 0; i < word.Length; i++)
            {
                if(strong.IsMatch(word[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        word[i].Substring(
                            word[i].IndexOf('>') + 1, 
                            ((word[i].LastIndexOf('<') -1) - word[i].IndexOf('>'))
                        )
                    );
                    Console.Write(" ");
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(word[i]);
                    Console.Write(" ");
                }
            }
            
        }
        public static void Start()
        {

        }
    }
}