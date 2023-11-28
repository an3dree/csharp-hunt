using System;
using System.Linq;
class Habilidades
{
    private int forca;
    public int Forca
    {
        get { return forca; }
        set { forca = value; }
    }

    private int constituicao;
    public int Constituicao
    {
        get { return constituicao; }
        set { constituicao = value; }
    }

    private int destreza;
    public int Destreza
    {
        get { return destreza; }
        set { destreza = value; }
    }

    private int inteligencia;
    public int Inteligencia
    {
        get { return inteligencia; }
        set { inteligencia = value; }
    }

    private int sabedoria;
    public int Sabedoria
    {
        get { return sabedoria; }
        set { sabedoria = value; }
    }

    private int carisma;
    public int Carisma
    {
        get { return carisma; }
        set { carisma = value; }
    }

    public int[] habilidades;
    Dice dice = new Dice();

    public void DefHabilidadesWithInfo()
    {

        int[] valores = new int[6];
        for (int i = 0; i <= 5; i++)
        {
            valores[i] = dice.Roll(4, 4, 4);
        }
        Console.WriteLine("Agora vamos definir suas Habilidades");
        Console.WriteLine($"Você tem os seguintes valores pra distribuir: {String.Join(",", valores)}");


        // TODO Do - While
        Console.WriteLine("Quais desses valores você gostaria de atribuir a Força?");
        int v1 = int.Parse(Console.ReadLine());
        if (valores.Contains(v1))
        {
            this.forca = v1;
            int indexV1 = Array.IndexOf(valores, v1);
            valores = valores.Where((e, i) => i != indexV1).ToArray();
        }
        else
        {
            Console.WriteLine("Valor inválido");
        }
        Console.WriteLine($"Força: {this.forca}");

        Console.WriteLine($"Valores disponíveis: " + String.Join(",", valores));
        Console.WriteLine("Quais desses valores você gostaria de atribuir a Destreza?");
        int v2 = int.Parse(Console.ReadLine());
        if (valores.Contains(v2))
        {
            this.destreza = v2;
            int indexV2 = Array.IndexOf(valores, v2);
            valores = valores.Where((e, i) => i != indexV2).ToArray();
        }
        else
        {
            Console.WriteLine("Valor Inválido");
        }
        Console.WriteLine($"Destreza: {this.destreza}");

        Console.WriteLine($"Valores disponíveis: " + String.Join(",", valores));
        Console.WriteLine("Quais desses valores você gostaria de atribuir a Constituição?");
        int v3 = int.Parse(Console.ReadLine());
        if (valores.Contains(v3))
        {
            this.constituicao = v3;
            int indexV3 = Array.IndexOf(valores, v3);
            valores = valores.Where((e, i) => i != indexV3).ToArray();
        }
        else
        {
            Console.WriteLine("Valor Inválido");
        }
        Console.WriteLine($"Constituição: {this.constituicao}");

        Console.WriteLine($"Valores disponíveis: " + String.Join(",", valores));
        Console.WriteLine("Quais desses valores você gostaria de atribuir a Inteligência?");
        int v4 = int.Parse(Console.ReadLine());
        if (valores.Contains(v4))
        {
            this.inteligencia = v4;
            int indexV4 = Array.IndexOf(valores, v4);
            valores = valores.Where((e, i) => i != indexV4).ToArray();
        }
        else
        {
            Console.WriteLine("Valor Inválido");
        }
        Console.WriteLine($"Inteligência: {this.inteligencia}");

        Console.WriteLine($"Valores disponíveis: " + String.Join(",", valores));
        Console.WriteLine("Quais desses valores você gostaria de atribuir a Sabedoria?");

    }

}