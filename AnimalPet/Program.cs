using System;

namespace AnimalPet // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, por gentileza nos informe cinco animais de estimação");
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            var animais = new List<Animal>() { a1, a2, a3, a4, a5 };
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine($"Digite o nome do {count + 1}º animal de estimação: ");
                animais[count].Nome = Console.ReadLine();
                Console.WriteLine($"Digite a especie do {count + 1}º animal de estimação(Gato, Cachorro, Peixe): ");
                animais[count].Especie.ToLower() = Console.ReadLine();
                //Console.WriteLine(count);
                // animais.Add(a[count]);
                count++;
            }
            Console.WriteLine(animais);
            int gatos = 0, cachorros = 0, peixes = 0;
            foreach (var animal in animais)
            {
                if (animal.Especie == "gato")
                {
                    gatos++;
                }
                else if (animal.Especie == "cachorro")
                {
                    cachorros++;
                }
                else if (animal.Especie == "peixe")
                {
                    peixes++;
                }
            }

            Console.WriteLine("Você tem");
            Console.WriteLine("Gatos: " + gatos);
            Console.WriteLine("Cachorros: " + cachorros);
            Console.WriteLine("Peixes: " + peixes);

        }
    }
}