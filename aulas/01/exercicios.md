1. Identifique para cada dado abaixo se ele é do tipo Inteiro, Real, Lógico ou Caractere:

    - Número de latas de refrigerante de uma prateleira
    - Nome de um assinante de uma linha telefônica
    - Quantidade de sacos de arroz vendidos em um mercado
    - Luz de um sinal de trânsito (assuma ‘V’ermelho, ‘A’marelo, v’E’rde)
    - Quantidade de litros de combustível no abastecimento em um posto
    - Número de alunos de uma turma
    - Quantidade de automóveis produzidos no mês por uma fábrica
    - Número de bois no pasto de uma fazenda
    - Quantidade de laranjas disponíveis em uma caixa
    - Nome do funcionário de um escritório
    - Número de notas de dinheiro no caixa de uma agência bancária
    - Quantidade de salas de aula de uma faculdade
    - Status do pagamento de uma fatura (pago ou não-pago)
    - Raiz de uma equação do segundo grau
    - Autor de um livro
    - Saldo bancário de um cliente
    - Uma letra minúscula do alfabeto
    - Número de canais de um serviço de TV à cabo
    - Valor da prestação de uma TV
    

2. Faça um algoritmo para exibir a multiplicação de dois números inteiros informados pelo usuário.

3. Faça um algoritmo para ler um número inteiro e exibir seu dobro.
4. Faça um algoritmo para ler 3 números reais e exibir a soma do primeiro número com o segundo, multiplicada pela soma do segundo com o terceiro.
5. Faça um algoritmo que lê um número real e escreve seu cubo.
6. Faça um algoritmo que lê dois números inteiros e escreva o resto da divisão do primeiro pelo segundo.
7. Faça um algoritmo que lê um número inteiro e imprime o valor do seu quadrado e de sua raiz quadrada.
8. Faça um algoritmo que lê um valor em reais e escreve o valor equivalente em dólares (considere que o dólar vale R$ 5,50).
9. Faça um algoritmo que lê o salário de um funcionário e escreve o salário acrescido de 15%.
10. Uma imobiliária vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um terreno e exibir a sua área.
11. Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os cavalos comprados por um haras.
12. Uma padaria vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa poupança (10% do total arrecadado). Você foi contratado para fazer os cálculos para o dono.
Com base nesses fatos, faça um algoritmo para ler as quantidades de pães e broas, e depois calcular os dados solicitados.

13. O que será impresso pelo seguinte algoritmo?

```c#
namespace Programa1 
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            num1 = 10;
            num2 = 20;
            num3 = num2 - num1;
            num3 = num1 - num2;

            Console.WriteLine(num3);
        }
    }
}
```

14. O que será impresso pelo seguinte algoritmo?

```c#
namespace Programa2 
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int pri;
            int seg;
            int ter;

            pri = 5;
            seg = pri;
            ter = seg;
            pri = 8;
            
            Console.WriteLine(pri);
            Console.WriteLine(seg);
            Console.WriteLine(ter);
        }
    }
}
```
