namespace CalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Digite seu Nome");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu ano de nascimento");
            pessoa1.AnoNascimento = int.Parse(Console.ReadLine());
            pessoa1.CalculaIdade(pessoa1.AnoNascimento);
            Console.WriteLine("Nome: " + pessoa1.Nome);
            Console.WriteLine("Idade: " + pessoa1.GetIdade());
            // var data = DateTime.Now;
            // int anoAtual = data.Year;
            // Console.WriteLine(anoAtual);
        }
    }
}