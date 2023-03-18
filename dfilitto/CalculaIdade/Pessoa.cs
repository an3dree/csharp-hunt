using System;

namespace CalculaIdade
{
    class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        private int anoNascimento;
        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        public void EdibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + CalcularIdade());
            Console.WriteLine("Ano de Nascimento: " + this.AnoNascimento);
        }

        private int CalcularIdade()
        {
            DateTime date = DateTime.Now;
            int anoAtual = date.Year;
            int idade = anoAtual - this.AnoNascimento;
            return idade;
        }

        // private int idade;

        // public int GetIdade()
        // {
        //     return this.idade;
        // }

        // public int CalculaIdade(int anoNascimento)
        // {
        //     var date = DateTime.Now;
        //     int ano = date.Year;
        //     this.idade = ano - this.anoNascimento;
        //     return this.idade;
        // }


    }
}