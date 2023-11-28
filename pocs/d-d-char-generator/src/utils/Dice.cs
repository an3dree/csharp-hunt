
class Dice
{
    public void RollWithInformation(int lados, int mod = 0, int quantidade = 1)
    {
        int count = 0;
        int result = 0;
        int soma = 0;
        var rand = new Random();

        Console.WriteLine($"Dado a ser rolado: d{lados}");
        Console.WriteLine($"Quantidade de rolagens: {quantidade}");
        Console.WriteLine();
        do
        {
            Console.WriteLine($"Rolagem numero: {count + 1}");
            result = Convert.ToInt32(rand.NextInt64(1, lados + 1));
            Console.WriteLine("Face voltada para cima = " + result);
            Console.WriteLine();
            count++;
            soma += result;

        } while (count < quantidade);

        soma = soma + mod;

        Console.WriteLine($"Valor do bonus a ser aplicado: {mod}");
        Console.WriteLine($"Valor do resultado final: {soma}");


    }

    public int Roll(int lados, int mod = 0, int quantidade = 1)
    {
        int count = 0;
        int result = 0;
        int soma = 0;
        var rand = new Random();
        do
        {
            result = Convert.ToInt32(rand.NextInt64(1, lados + 1));
            count++;
            soma += result;

        } while (count < quantidade);

        return soma + mod;
    }

}