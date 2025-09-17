using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Interpolation();
        }

        //Guid
        static void Guids(){
            var id = Guid.NewGuid();
            id.ToString();
            Console.WriteLine(id);
            // tudo 0
            id = new Guid();
            id = new Guid("dbbec4b9-34f4-48fe-9d84-029b4f36f1c9");
            Console.WriteLine(id);

            //if(id == Guid.NewGuid())
            Console.WriteLine(id.ToString().Substring(0,8));

        }

        static void Interpolation(){
            var price = 10.2;
            //var text = "The price is: " + price;
            var text = string.Format("The product price is {1} only in promotion {0}", price, true);

            var otherText = $"The product price is {price}";
            
            Console.WriteLine(text);
        }

        // Comparação de Strings
        static void CompareStrings(){
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando"));
            Console.WriteLine(texto.CompareTo("testando"));

            var outroTexto = "Alow howmoura, dale men!";
            Console.WriteLine(outroTexto.Contains("dale")); // retorna true
            Console.WriteLine(outroTexto.Contains("Dale")); // retorna false
             
            // vai ignorar a primeira letra e retorna true
            Console.WriteLine(outroTexto.Contains("Dale", StringComparison.OrdinalIgnoreCase));
        
        }

        // Start With and End With
        static void StartAndEndWith(){
            var texto = "texto de teste blz men";
            Console.WriteLine(texto.StartsWith("texto"));
            Console.WriteLine(texto.StartsWith("Texto"));
            Console.WriteLine(texto.StartsWith("Texto", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("tex"));

            Console.WriteLine(texto.EndsWith("men"));
            Console.WriteLine(texto.EndsWith("Men"));
            Console.WriteLine(texto.EndsWith("en"));

        }

        static void Igual(){
            var texto = "texto de teste blz men";
            var numero = 33;
            Console.WriteLine(numero.Equals(33));
            Console.WriteLine(texto.Equals("texto de teste blz men"));
            Console.WriteLine(texto.Equals("Texto de teste blz men"));

        }

        static void Indices(){
            var texto = "texto de teste blz men";
            Console.WriteLine(texto.IndexOf("d"));
            Console.WriteLine(texto.LastIndexOf("e"));
            
        }

        static void OutrosMetodos(){
             var texto = "texto de teste blz men";
             Console.WriteLine(texto.ToLower());
             Console.WriteLine(texto.ToUpper());

             Console.WriteLine(texto.Insert(6, "cheguei").ToUpper());
             Console.WriteLine(texto.Remove(6, 7));
             Console.WriteLine(texto.Length);

        }

        static void Manipulation(){
            var texto = "texto de teste blz men";   
            Console.WriteLine(texto.Replace("teste", "hahiw"));
            Console.WriteLine(texto.Replace("e", "W"));

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(2, 7);
            Console.WriteLine(resultado);
            resultado = texto.Substring(4, texto.LastIndexOf("e"));
            Console.WriteLine(resultado);

            Console.WriteLine(texto.Trim()); // sem espaço no começo e no final

        }

        static void Builders(){
            var texto = "texto de teste blz men"; 
            texto += " hahaha";

            var outroTexto = new StringBuilder();
            outroTexto.Append(" mais coisa nele");
        }
    }
}
