# Estruturas de Decisão
<br>

## Comando Switch
<br>

O comando <code>switch case</code> é útil em situações que precisa-se testar possíveis valores para uma mesma variável
Cada valor exige a execução de comandos diferentes

Uma expressão é comparada a diversos valores de acordo com a ordem definida

Ao encontrar uma ocorrência do valor correto, o comando relativo é executado e o algoritmo segue para o fim do comando

Se nenhum dos valores for igual à expressão, poderá ser executado um outro comando através do complemento <code>default</code>

<br>

### Comando Switch Case Sintaxe:
<br>

```c#
switch(<expressão de seleção>) 
{
  case x:
    // sequencia de comandos
    break;
  case y:
    // sequencia de comandos
    break;
  default:
    // sequencia de comandos
    break;
}
```
<br>

### Comando Switch Case - Exemplo:
<br>

```c#
switch(numero) 
{
  case 1:
    Console.WriteLine("Um");
    break;
  case 2:
    Console.WriteLine("Dois");
    break;
  case 3: 
    Console.WriteLine("Três");
    break;
  default:
    Console.WriteLine("Inválido");
    break;
}
```
<br>

<br>


### Limitações do comando Switch Case
<br>

- Permite apenas comparações de igualdade, NÃO permitindo as demais comparações relacionais (maior que, menor que, etc.)

- Todo comando Switch Case pode ser substituído por um (ou mais) comandos If, mas a recíproca não é verdadeira.

