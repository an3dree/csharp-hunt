# Estruturas de Decisão

Existem situações em que desejamos que nem todos os comandos de um algoritmo sejam executados

Nestas situações, ensinamos o computador a tomar decisões, optando ou não por executar determinados comandos

Como os computadores não tomam decisões sozinhos, devemos instruí-lo a seguir um determinado caminho no algoritmo

Para isto é necessário um teste que resulte em uma expressão lógica (verdadeiro ou falso)

<br>

## Comando If

Estrutura de decisão básica em algoritmos

Sintaxe:

```c#
if(<expressão lógica>)
{
    <sequência de comandos> // só executa se a expressão lógica for verdadeira
}
```

<br>

## Comando If...Else

Sintaxe:
```c#
if(<expressão lógica>)
{
    <sequência de comandos 1> // só executa se a expressão lógica for verdadeira
}
else
{
    <sequência de comandos 2> // só executa se a expressão lógica for falsa
}
```

<br>
<br>

### Estrutura de decisão aninhadas
<br>

- Em algumas situações é necessário a realização de testes dentro de outros testes
- Esta necessidade surge da combinação de decisões a serem tomadas
- Este tipo de estrutura é chamado de aninhamento ou encadeamento

<br>
<br>
Estruturas de decisão aninhadas - Exemplo de Sintaxe

```c#
if(<expressão lógica 1>)
{
    if(<expressão lógica 2>)
    {
        <sequência de comandos 1>
    }
}
else
{
    if(<sequência de comandos 3>)
    {
        <sequência de comandos 2>
    }
    else
    {
        <sequência de comandos 3>
    }
}
```



