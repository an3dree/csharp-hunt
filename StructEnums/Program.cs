using System;

namespace StructEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem alora = new Personagem();
            alora.Id = 1;
            alora.Level = 2;
            alora.Nome = "Alora";
            alora.Classe = EClasse.Guerreiro;
            alora.Raca = ERaca.Humano;
            double aloraGold = alora.dinheiroInicial(alora.Level);
            //Console.WriteLine(alora);
            Console.WriteLine($"Informações do personagem {alora.Nome}");
            Console.WriteLine($"Id: {alora.Id}");
            Console.WriteLine($"Nome: {alora.Nome}");
            Console.WriteLine($"Level: {alora.Level}");
            Console.WriteLine($"Classe: {alora.Classe} nº da classe: {(int)alora.Classe}");
            Console.WriteLine($"Raça: {alora.Raca} nº da Raça: {(int)alora.Raca}");
            Console.WriteLine($"Dinheiro: {aloraGold}");

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Personagem minerva = new Personagem(2, "Minerva", ERaca.Anao, EClasse.Arqueiro, 3);
            double minervaGold = minerva.dinheiroInicial(minerva.Level);
            Console.WriteLine($"Informações do personagem {minerva.Nome}");
            Console.WriteLine($"Id: {minerva.Id}");
            Console.WriteLine($"Nome: {minerva.Nome}");
            Console.WriteLine($"Level: {minerva.Level}");
            Console.WriteLine($"Classe: {minerva.Classe} nº da Classe: {(int)minerva.Classe}");
            Console.WriteLine($"Raça: {minerva.Raca} nº da Raça: {(int)minerva.Raca}");
            Console.WriteLine($"Dinheiro: {minervaGold}");

        }

        struct Personagem {
            // propriedades
            public int Id;
            public string Nome;
            public ERaca Raca;
            public EClasse Classe;

            public int Level;

            public Personagem(int id, string nome, ERaca raca, EClasse classe, int level){
                Id = id;
                Nome = nome;
                Raca = raca;
                Classe = classe;
                Level = level;
            }

            public double dinheiroInicial(int level){
                double dinheiro = level * 4.3;
                return dinheiro;
            }
        }

        enum EClasse {
           
           Guerreiro = 1,
           Mago = 2,
           Arqueiro = 3,
           Clerigo = 4

        }

        enum ERaca {
            Humano = 1,
            Elfo = 2,
            Anao = 3,
            Orc = 4
        }
    }
}
