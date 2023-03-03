using System;

namespace racas 
{
    public class Racas
    {
        //string anao, humano, elfo, halfling, orc, gnomo;

        public static string consus(){
            
            Console.WriteLine("Escolha sua Raça");
            Console.WriteLine("1 - Anão");
            Console.WriteLine("2 - Humano");
            Console.WriteLine("3 - Elfo");
            Console.WriteLine("4 - Halfling");
            Console.WriteLine("5 - Orc");
            string escolha = Console.ReadLine();
            switch (escolha){
                case "1":
                escolha = "Anão";
                break;
                case "2":
                escolha = "Humano";
                break;
                case "3":
                escolha = "Elfo";
                break;
                case "4":
                escolha = "Halfling";
                break;
                case "5":
                escolha = "Orc";
                break;
            }
                
            return escolha;
        }     
    }
}
