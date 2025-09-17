﻿using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());
            switch(option)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    AbrirArquivo();
                    break;
                case 2:
                    EditarArquivo();
                    break;
                default:
                    Menu();
                    break;
            }
                
        }

        static void AbrirArquivo()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine();
            Console.ReadLine();
            Menu();
        }
        static void EditarArquivo()

        {
            Console.Clear();
            Console.WriteLine("Digite seu texto (ESC para sair)");
            Console.WriteLine("----------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += System.Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            SalvarArquivo(text);

        }
        
        static void SalvarArquivo(string text)
        {
            Console.Clear();
            Console.WriteLine(" Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            //Console.ReadLine();
            Menu();

        }
    }
}
