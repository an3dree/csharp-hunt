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
            pessoa1.EdibirDados();

            // var data = DateTime.Now;
            // int anoAtual = data.Year;
            // Console.WriteLine(anoAtual);
        }
    }
}