using System;
using System.Collections.Generic;
using System.Text;

namespace DeclararUsarVariaveis
{
    public class Numbers
    {
        public Numbers()
        {
            // https://docs.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp?tutorial-step=1
            // Explorar a matemática de inteiros.
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            // O tipo de inteiro C# difere do inteiros matemáticos de outra forma: o tipo int tem limites mínimo e máximo.
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            // Trabalhar com o tipo Double.
            double a1 = 5;
            double b1 = 4;
            double c1 = 2;
            double d1 = (a1 + b1) / c1;
            Console.WriteLine(d1);

            // O intervalo de um valor duplo é muito maior do que valores inteiros
            double max1 = double.MaxValue;
            double min1 = double.MinValue;
            Console.WriteLine($"The range of double is {min1} to {max1}");

            // Observe que o intervalo é menor do que o tipo double
            Console.WriteLine("Observe que o intervalo é menor do que o tipo double");
            double a2 = 1.0;
            double b2 = 3.0;
            Console.WriteLine(a2 / b2);

            decimal c2 = 1.0M;
            decimal d2 = 3.0M;
            Console.WriteLine(c2 / d2);
            // O sufixo M nos números é o modo como você indica que uma constante deve usar o tipo decimal.
            // Observe que o cálculo usando o tipo decimal tem mais dígitos à direita da vírgula decimal.
            // O sufixo M nos números é o modo como você indica que uma constante deve usar o tipo decimal.
            // Caso contrário, o compilador assume o double tipo.
        }
    }
}
