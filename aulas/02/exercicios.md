1.  Utilizando teste de mesa, mostre o que será impresso pelo algoritmo a seguir, deixando explícito os valores de cada uma das variáveis ao executar cada instrução passo a passo:

```c#
namespace Programa1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            a = 10;
            b = 8;
            c = 4;
            a = a + c;
            b = a;
            c = a + b;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
```
2. O que faz o algoritmo a seguir? Dica: use o teste de mesa supondo valores de entrada para x e y.

```c#
namespace Programa2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double x;
            double y;
            double k;

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            k = x;
            x = y;
            y = k;
            
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
```

3. Utilizando teste de mesa, mostre o que será impresso no algoritmo a seguir, deixando explícito os valores de cada uma das variáveis ao executar cada instrução passo a passo:


```c#
namespace Programa3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a;
            double b;
            double c;
            char l;

            b = 8.4;
            a = int.Parse(b);
            c = b - a;
            c = c * 10;
            l = "c";
            
            Console.WriteLine(c);
            Console.WriteLine("l");
            Console.WriteLine(l);
        }
    }
}
```

4. O que faz o algoritmo a seguir? Dica: use o teste de mesa supondo um valor de entrada para x.


```c#
namespace Programa4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int x;
            int aux;
            int p1;
            int p2;
            int p3;

            x = int.Parse(Console.ReadLine());
            aux = x;
            p1 = aux % 10;
            aux = aux \ 10;
            p2 = aux % 10;
            aux = aux \ 10;
            p3 = aux % 10;
            
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
```

5. Utilizando teste de mesa, mostre o que será impresso no algoritmo a seguir, deixando explícito os valores de cada uma das variáveis ao executar cada instrução passo a passo:


```c#
namespace Programa5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double v;
            double r;

            v = 1000;
            r = 15 / 100;
            v = v + r * v;
            v = v + r * v;
            v = v + r * v;
            
            Console.WriteLine(v);
        }
    }
}
```
