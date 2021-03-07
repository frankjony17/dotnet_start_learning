using System;
using System.Collections.Generic;
using System.Text;

namespace DeclararUsarVariaveis
{
    class MakeDecisionsAndLoops
    {
        public MakeDecisionsAndLoops()
        {
            // Tomar decisões usando a instrução if.
            int a = 5;
            int b = 6;

            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");

            // Faça if e else funcionam juntas.
            int a1 = 5;
            int b1 = 3;
            if (a1 + b1 > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");

            // Como o recuo não é significativo, você precisa usar { e }
            // para indicar quando você deseja que mais de uma instrução faça parte do bloco que é executado condicionalmente.
            // Os programadores em C# normalmente usam essas chaves em todas as cláusulas if e else. O exemplo a seguir é o
            // mesmo que você criou. Experimente.
            int a2 = 5;
            int b2 = 3;

            if (a2 + b2 > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            // Use loops para repetir operações.
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            int counter1 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter1}");
                counter1++;
            } while (counter1 < 10);

            // Trabalhar com o loop for
            for (int counter2 = 0; counter2 < 10; counter2++)
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
            }

            // Outro loop pode gerar as colunas:
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The column is {column}");
            }

            // Você pode aninhar um loop dentro do outro para formar pares:
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }
    }
}
