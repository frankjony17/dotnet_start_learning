using System;
using System.Collections.Generic;
using System.Text;

namespace DeclararUsarVariaveis
{
    public class CadeiasDeCaracteres
    {
        public CadeiasDeCaracteres ()
        {
            // https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/strings/
            Console.WriteLine("Hello World!");

            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            aFriend = "Maira";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");

            // Trabalhar com cadeias de caracteres.
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            // O método Trim e os métodos relacionados TrimStart e TrimEnd fazem isso funcionar.
            // Você pode apenas usar esses métodos para remover espaços à esquerda e à direita.
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");
            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            // O método Replace faz algo semelhante em uma cadeia de caracteres.
            // Ele procura uma subcadeia de caracteres e a substitui por outro texto.
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            // TODA EM MAIÚSCULAS ou toda em minúsculas
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            // Pesquisar cadeias de caracteres
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            // Há dois métodos semelhantes, StartsWith e EndsWith que também procuram subcadeias de caracteres em uma cadeia de caracteres.
            // Eles encontram uma subcadeia de caracteres no início ou no final da cadeia de caracteres.
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

            //Literais de cadeia de caracteres regulares e textuais.
            string quote = @"Her name was ""Sara.""";
            //Output: Her name was "Sara."

            // Você pode usar a notação de matriz com um valor de índice para adquirir acesso somente leitura a caracteres individuais,
            //como no seguinte exemplo:
            string s5 = "Printing backwards";

            for (int i = 0; i < s5.Length; i++)
            {
                System.Console.Write(s5[s5.Length - i - 1]);
            }
            // Output: "sdrawkcab gnitnirP"

            // StringBuilder para modificar os caracteres individuais "in-loco" e criar uma nova cadeia de caracteres
            // para armazenar os resultados usando os métodos StringBuilder
            string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
            System.Text.StringBuilder sb = new System.Text.StringBuilder(question);

            for (int j = 0; j < sb.Length; j++)
            {
                if (System.Char.IsLower(sb[j]) == true)
                    sb[j] = System.Char.ToUpper(sb[j]);
                else if (System.Char.IsUpper(sb[j]) == true)
                    sb[j] = System.Char.ToLower(sb[j]);
            }
            // Store the new string.
            string corrected = sb.ToString();
            System.Console.WriteLine(corrected);
            // Output: How does Microsoft Word deal with the Caps Lock key?

            // https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/strings/
        }
    }
}
