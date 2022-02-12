using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i;
            /*
            Console.WriteLine(i);
            
            Console.WriteLine(i);
            */
            double numberOne;
            double numberTwo;
            do {
                Console.Clear();
                Console.WriteLine("Escolha a operação");
                Console.WriteLine("1 - Soma \n2 - Subtração \n3 - Multiplicação \n4 - Divisão\n5 - Para sair");
                i = int.Parse(Console.ReadLine());
                switch (i){

                case 1:
                Console.WriteLine("SOMA");
                Console.WriteLine("Digite o primeiro numero");
                numberOne = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                numberTwo = double.Parse(Console.ReadLine());
                double somaResul = soma(numberOne, numberTwo);
                Console.WriteLine("O resultado da soma é: " + somaResul);
                break;

                case 2:
                Console.WriteLine("SUBTRAÇÃO");
                Console.WriteLine("Digite o primeiro numero");
                numberOne = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                numberTwo = double.Parse(Console.ReadLine());
                double subResul = subtration(numberOne, numberTwo);
                Console.WriteLine("O resultado da subtração é: " + subResul);
                break;

                case 3:
                Console.WriteLine("MULTIPLICAÇÃO");
                Console.WriteLine("Digite o primeiro numero");
                numberOne = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                numberTwo = double.Parse(Console.ReadLine());
                double multResul = mult(numberOne, numberTwo);
                Console.WriteLine("O resultado da mutiplicação é: " + multResul);
                break;

                case 4:
                Console.WriteLine("DIVISÃO");
                Console.WriteLine("Digite o primeiro numero");
                numberOne = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                numberTwo = double.Parse(Console.ReadLine());;
                double divResul = subtration(numberOne, numberTwo);
                Console.WriteLine("O resultado da divisão é: " + divResul);
                break;

                case 5:
                i = 5;
                break;

            }
            } while (i != 5);
            
            
            Console.WriteLine("Saí do loop");
            Console.WriteLine("Hello World!");
        }

        static double soma(double a, double b){
            double res = a + b;
            return res;
        }
        static double subtration(double a, double b){
            double res = a - b;
            return res;
        }
        static double mult(double a, double b){
            double res = a * b;
            return res;
        }
        static double division(double a, double b){
            double res = a / b;
            return res;
        }
    }
}
