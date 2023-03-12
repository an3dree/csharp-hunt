# Conceitos Básicos
## Sintaxe e Semântica
Antes de entrar em maiores detalhes sobre a construção de algoritmos é necessário entender a diferença entre sintaxe e semântica.

### Sintaxe:
    Nome dado ao conjunto de regras a serem seguidas para a escrita dos algoritmos. O computador só é capaz de entender algoritmos sintaticamente corretos. Sintaxe está associada a forma de escrever um comando.

### Semântica:
    Refere-se ao que é efetuado pelo computador quando ele encontra um comando. Semântica está relacionada ao conteúdo de um comando.


## Introdução a C# e .NET

### C#
    C# é uma linguagem de programação orientada a objetos e orientada a componentes. C# fornece construções de linguagem para dar suporte diretamente a esses conceitos, tornando C# uma linguagem natural para criação e uso de componentes de software.

### .NET
    O .NET é uma plataforma de desenvolvedor multiplataforma de código aberto gratuita para criar muitos tipos diferentes de aplicativos.

    Com o .NET, você pode usar vários idiomas, editores e bibliotecas para criar para Web, dispositivos móveis, desktop, jogos, IoT e muito mais.

### Por quê aprender C# e .NET?
    C# não é só uma linguagem versátil, que permite você desenvolver qualquer coisa para qualquer plataforma. Ele também permite que você desenvolva programas de maneira bem estruturada e escalável. Por ser orientada a objetos e de tipagem forte, dá mais robustez ao código e permite ser estendido mais facilmente.

### Onde é Utilizado?
    - Aplicações Windows Desktop
    - Aplicações Desktop para Mac Os
    - Aplicações Mobile Cross-Platform para Android, Windows e Windows Phone
    - Aplicações Web com ASP.Net
    - Jogos 2D e 3D multiplataformas com Unity
    - Jogos em 2D e 3D para Windows e XBox
    - Aplicações embarcadas IoT (Internet das Coisas) que rodam em Raspberry PI 3
    - Universal Windows Apps (UWA) que rodam em qualquer Windows 10 (desktop, tablet and mobile), MS Hololens e Xbox.


<br>

## Conceitos Básicos

Antes de entrarmos em detalhe sobre como criar um algoritmo, é preciso entender alguns conceitos básicos:
- Tipos de dados
- Operadores
- Variáveis
- Comandos de Entrada e Saída - Input Output (I/O)    
<br>
<br>
## Tipos de Dados   


Existem 4 tipos de dados primitivos que serão utilizados com frequencia para criação de algoritmos:
<br>
<br>

| Tipo de Dado      | Descrição |
| ----------- | ----------- |
| Inteiro      | Para representar informações que não possuem parte fracionária       |
| Real   | Para representar informações que podem possuir parte fracionária        |
| Boleano   | Para representar um estado ou situação que pode ser apenas verdadeira ou falsa        |
| Caractere   | Utilizado para armazenar um sequência de caracteres na memória        |

<br>
<br>

### Identificação dos tipos de dados
 - Salário do funcionário de uma empresa
 - Quantidade de vendedores de uma loja
 - Preço de um litro de leite
 - Estado de iluminação de uma lâmpada em perfeitas condições
 - Preenchimento do sexo de uma pessoa em um formulário (assuma ‘M’ ou ‘F’)
 - CEP de uma carta
 - Resposta de uma questão de múltipla escolha
 - Placa de um automóvel
 - Valor a pagar por uma refeição num restaurante a quilo
 - Número de cheques emitidos por um cliente em um mês


<br>
<br>

## Operadores aritiméticos
Utilizados para obtenção de dados numéricos<br>
Resultam em valores numéricos

 - Adição +
 - Subtração -
 - Multiplicação *
 - Divisão real entre dois números /
 - Divisão inteira entre dois números \
 - Resto da divisão inteira entre dois números inteiros %
<br>
<br>
### Precedência de operadores aritméticos
1. ( ) Parênteses
2. '*' Multiplicação, / divisão e % resto da divisão
3. '+' Adição e - subtração
<br>
<br>
<br>
### Operadores aritméticos - Exemplo
<br>
3 * (1 – 2) + 4 * 2 / 8 <br>
3 * -1 + 4 * 2 / 8 <br>
-3 + 4 + 2 / 8 <br>
-3 + 4 + 0,25 <br>
-1 + 0,25 <br>
-0,75

<br>
<br>
<br>

### Operadores relacionais
Utilizados na comparação de dois valores de tipos iguais<br>
Resultam em valores lógicos
<br>
<br>
- Igual a =
- Diferente de <>
- Maior que >
- Menor que <
- Maior ou igual a >=
- Menor ou igual a <=
<br>
<br>
### Operadores relacionais - exemplo

2 * (5 + 2) / 7 + 1 = 5 <br>
2 * 7 / 7 + 1 = 5<br>
14 / 7 + 1 = 5<br>
2 + 1 = 5<br>
3 = 5<br>
falso

<br>
<br>
<br>

## Operadores lógicos
Utilizados para combinar valores lógicos<br>
Resultam em valores lógicos

- e, and, &&
- ou, or, ||
- não, not, !
<br>
<br>
### Tabela verdade dos operadores lógicos

| X      | Y | X and Y|
| ----------- | ----------- | - |
| verdadeiro (1)      | falso (0)       | falso (0)|
| verdadeiro (1)   | verdadeiro (1)         | verdadeiro (1) |
| falso (0)       | verdadeiro (1)  | falso (0)|
| falso (0)      | falso (0)       | falso (0)|

<br>
<br>

| X      | Y | X or Y|
| ----------- | ----------- | - |
| verdadeiro (1)      | falso (0)       | verdadeiro (1)|
| verdadeiro (1)   | verdadeiro (1)         | verdadeiro (1) |
| falso (0)       | verdadeiro (1)  | verdadeiro (1)|
| falso (0)      | falso (0)       | falso (0)|

<br>
<br>

### Operadores lógicos - exemplo
<br>
(3 = 5) e (4 > 2) = falso<br>
falso e (4 > 2) = falso<br>
falso e verdadeiro = falso<br>
falso = falso<br>
verdadeiro
<br>
<br>
<br>
<br>

## Variáveis
<br>

- Um dos conceitos mais importantes na construção de algoritmos
- Representa um espaço de memória reservado para armazenar um dado de um determinado tipo
- Deve receber um nome para referenciação e modificação
- Deve possuir um tipo associado (inteiro, real, logico, caractere)
- Só podem armazenar um dado por vez

<br>

### Nomes de variáveis
Os nomes de variáveis devem:
- Começar por uma letra e depois conter letras, números ou underline
- Ter um limite de 30 caracteres
- Não pode haver duas variáveis com o mesmo nome

<br>

### Declaração de Variáveis
Toda variável utilizada em um algoritmo deve ser, primeiramente, declarada<br>

A sintaxe de declarção é: <br>

```c#
tipoVariavel nomeVariavel
```


Exemplo:

```c#
int idade;
```
<code>int idade;</code>

<br>


### Atribuição de Valores a variáveis
Considerando que uma variável foi declarada, é possível atribuir um valor à ela.

A sintaxe de atribuição é:<br>
```c#
nomeVariavel = valor;
```

Exemplos:

```c#
idade = 50;
nome = "André Luiz";
```

<br>
<br>

## Entrada e Saída - Input Output (I/O)
<br>

### Comando de entrada de dados - Input
Normalmente precisamos de dados de entrada para serem processados pelos algoritmos

Em C# existe comando para solicitar e obter dados fornecidos pelo usuário

Esse comando irá sempre retornar uma string, então devemos tomar cuidado
```C#
Console.ReadLine()
```

### Sintaxe e Exemplos:
```c#
nome = Console.ReadLine();

idade = int.Parse(Console.ReadLine());
```


como o método ``Console.ReadLine()`` só irá ler valores strings, utilizamos o método ``Parse()`` para realizar a conversão

<br><br>
### Funcionamento do comando `Console.ReadLine()`
 - Quando um computador encontra um comando de entrada de dados, ele suspende a execução do programa até que os dados sejam fornecidos

- Depois que o usuário digita os dados e aperta enter, o computador atribui o valor digitado à variável passada ao comando leia

<br><br>
### Comando de saída de dados - Output
Da mesma forma que um algoritmo precisa receber dados externos, precisa também apresentar informações aos usuários

Há um comando para imprimir dados e informações na tela do usuário

A sintaxe do comando de saída de dados é:

```c#
Console.WriteLine("Hello World");
```

Exemplos:
```c#
Console.WriteLine("Digite o primeiro número a ser somado");
```
````c#
Console.WriteLine("O resultado da soma é: " + soma);
````
<br>

## Estrutura dos algoritmos no C# do .NET

<br>

```c#
namespace NomeDoPrograma // nome da aplicação
{
    class Program
    {
        // Início da aplicação
        static void Main(string[] args)
        {
            // Função principal da aplicação
            Console.WriteLine("Hello World");
            
            // A lógica do programa deve ser escrita aqui
        }
    }
}
```






