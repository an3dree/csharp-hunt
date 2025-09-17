# Teste de Mesa

## Verificação Manual de Algoritmos

 - Após criar um algoritmo você pode (e deve) verificar se o mesmo realmente é uma solução para o problema

- Forma “braçal” denominada teste de mesa ou método chinês

- Simulação manual da execução do algoritmo, comando após comando
Atentando para as entradas e saídas de dados e verificando o comportamento das variáveis

- Equivale a colocar-se no papel do computador, anotando o que a máquina faria a cada comando

<br>

## Teste de Mesa Exemplo


```c#
namespace Programa1 
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num1;
            int num2;
            double soma;
            double media;

            num1 = int.Parse(Console.ReadLine());
            num1 = int.Parse(Console.ReadLine());

            soma = num1 + num2;
            media = soma / 2

            Console.WriteLine(media);
        }
    }
}
```
