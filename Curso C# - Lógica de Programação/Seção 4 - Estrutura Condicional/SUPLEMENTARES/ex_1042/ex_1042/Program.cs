using System;
using System.Globalization;

namespace ex_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1042

            int num1, num2, num3;

            string[] vet = Console.ReadLine().Split(' ');
            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            num3 = int.Parse(vet[2]);

            if (num1 < num2 && num1 < num3) // SE: num1 < (num 2 e num3) 
            {
                if (num2 < num3)                          // SE: num1 < num 2 < num3
                {
                    Console.WriteLine(num1);                 // [escrever em ordem crescente]
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);

                    Console.WriteLine();                     // [escrever como foram lidos inicialmente]
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
                else                                      // SE: num1 < num 3 < num2
                {
                    Console.WriteLine(num1);                // [escrever em ordem crescente]
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);

                    Console.WriteLine();                    // [escrever como foram lidos inicialmente]
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
            } else if (num2 < num1 && num2 < num3) // SE: num2 < (num 1 e num3)
            {
                if (num1 < num3)                          // SE: num2 < num 1 < num3  
                {
                    Console.WriteLine(num2);                // [escrever em ordem crescente]
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);

                    Console.WriteLine();                    // [escrever como foram lidos inicialmente]
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
                else                                      // SE: num2 < num 3 < num1
                {
                    Console.WriteLine(num2);                // [escrever em ordem crescente]
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);

                    Console.WriteLine();                    // [escrever como foram lidos inicialmente]
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
            } else                                 // SE: num3 < (num1 e num2)
            {
                if (num1 < num2)                         // SE: num 3 < num1 < num2
                {
                    Console.WriteLine(num3);                // [escrever em ordem crescente]
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);

                    Console.WriteLine();                    // [escrever como foram lidos inicialmente]
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                } else                                   // SE: num 3 < num2 < num1
                {
                    Console.WriteLine(num3);                // [escrever em ordem crescente]
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);

                    Console.WriteLine();                    // [escrever como foram lidos inicialmente]
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
            }
        }
    }
}