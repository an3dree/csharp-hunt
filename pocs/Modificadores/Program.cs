using System;
using racas;
using habilidades;

namespace repos 
{
    class Program 
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Habilidades");
            Console.WriteLine("Digite seu valor de força");
            int inputforca = Console.Read();
            Console.WriteLine("Digite seu valor de Constituição");
            int inputconstituicao = Console.Read();
            Console.WriteLine("Digite seu valor de Inteligência");
            int inputinteli = Console.Read();
            Console.WriteLine("Digite seu valor de Sabedoria");
            int inputsabedoria = Console.Read();
            Console.WriteLine("Digite seu valor de Carisma");
            int inputcarisma = Console.Read();
            Console.WriteLine("Digite seu valor de Destreza");
            int inputdestreza = Console.Read();

            Console.WriteLine(inputforca);
            Console.WriteLine(inputconstituicao);
            Console.WriteLine(inputinteli);
            Console.WriteLine(inputsabedoria);
            Console.WriteLine(inputcarisma);
            Console.WriteLine(inputdestreza);
            */
            Racas.consus();
            Console.WriteLine(Habilidades.askHab(12,12,12,12,12,12));

            
        }
    }
}
