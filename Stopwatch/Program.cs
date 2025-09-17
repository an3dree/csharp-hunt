using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("S = Segundo => 10s = 10 segundos");
                Console.WriteLine("M = Minuto => 1m = 1 minuto");
                Console.WriteLine("0 = Sair");
                Console.WriteLine("Quanto tempo deseja contar?");

                string userInput = Console.ReadLine().ToLower();
                if(userInput.Length > 1){
                    char timeType = char.Parse(userInput.Substring(userInput.Length - 1,1));
                    int timeInput = int.Parse(userInput.Substring(0 ,userInput.Length - 1));
                    int multiplayers = 60;

                
                
                    if(timeType == 's')
                        multiplayers = 1;
                    
                    if(timeInput == 0)
                        System.Environment.Exit(0);

                    PressStart(timeInput * multiplayers);
                }
                else if(int.Parse(userInput) == 0)
                {
                    System.Environment.Exit(0);
                } 
                
                
                
            }
            catch(Exception e){
                //Console.WriteLine(e);
                Console.WriteLine("Valor Inválido");
                Thread.Sleep(1500);
                Console.WriteLine("Retornando ao menu...");
                Thread.Sleep(2000);
                Menu();
            }
            


        }

        static void PressStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);
            Start(time);
        }
    
        static void Start(int time)
        {
            
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(2000);
            Menu();
        }
    }

}
