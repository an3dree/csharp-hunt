using System;

namespace CalculaIdade
{
    class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int anoNascimento;
        public int AnoNascimento
        {
            get { return anoNascimento; }
            set { anoNascimento = value; }
        }

        private int idade;

        public int GetIdade()
        {
            return this.idade;
        }

        public int CalculaIdade(int anoNascimento)
        {
            var date = DateTime.Now;
            int ano = date.Year;
            this.idade = ano - this.anoNascimento;
            return this.idade;
        }


    }
}