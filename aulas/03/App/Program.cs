using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Questao5();
            static void Questao5()
            {
                /*
                           5-Um mercado está vendendo produtos com a seguinte tabela de preços:

                               Total de compras até 10 Kg	Total de compras acima de 10Kg
                                   Carambolas: R$ 5,00 p/Kg	Carambolas: R$ 4,50 p/Kg
                                   Amoras: R$ 3,00 p/Kg	Amoras: R$ 2,00 p/Kg

                           Caso o cliente compre mais de 15Kg em frutas ou o valor total da 
                           compra ultrapasse R$ 35,00, receberá ainda um desconto de 20% sobre esse total. 
                           Faça um algoritmo para ler a quantidade (em Kg) de carambolas e a quantidade (em Kg) 
                           de amoras adquiridas e escreva o valor a ser pago pelo cliente.
                           */
                double precoAmora = 3, precoCarambola = 5, precoTotal = 0, pesoAmora, pesoCarambola, pesoTotal;
                double totalAmoras, totalCarambolas;

                Console.WriteLine("Bem vindo a feira!");

                Console.WriteLine("Quantos quilos de amora vai querer?");
                pesoAmora = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantos quilos de carambola vai querer?");
                pesoCarambola = double.Parse(Console.ReadLine());

                pesoTotal = pesoAmora + pesoCarambola;
                precoTotal = (precoAmora * pesoAmora) + (precoCarambola * pesoCarambola);

                if (pesoTotal >= 10)
                {
                    if (pesoTotal >= 15 || precoTotal >= 35)
                    {
                        precoAmora = 2;
                        precoCarambola = 4.5;

                        totalAmoras = pesoAmora * precoAmora;
                        totalCarambolas = pesoCarambola * precoCarambola;
                        precoTotal = totalAmoras + totalCarambolas;
                        precoTotal = precoTotal * 0.2;
                    }
                    precoAmora = 2;
                    precoCarambola = 4.5;

                    totalAmoras = pesoAmora * precoAmora;
                    totalCarambolas = pesoCarambola * precoCarambola;
                    precoTotal = totalAmoras + totalCarambolas;
                }
                else
                {
                    totalAmoras = pesoAmora * precoAmora;
                    totalCarambolas = pesoCarambola * precoCarambola;
                    precoTotal = totalAmoras + totalCarambolas;
                }



                Console.WriteLine(pesoAmora + "Kgs de amora");
                Console.WriteLine(pesoCarambola + "Kgs de carambola");
                Console.WriteLine("Peso total: " + pesoTotal);
                Console.WriteLine("O valor total da compra deu: " + precoTotal);
            }
        }
    }
}