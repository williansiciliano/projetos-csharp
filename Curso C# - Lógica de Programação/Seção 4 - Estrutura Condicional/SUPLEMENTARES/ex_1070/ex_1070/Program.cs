using System;
using System.Globalization;

namespace ex_1070
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1070

            int N, num1, num2, num3, num4, num5, num6;

            N = int.Parse(Console.ReadLine());

            if (N <= 0 ) {
                Console.WriteLine("Digite um número maior do que zero!");
            } else
            {
                if (N % 2 == 0)
                {
                    num1 = N + 1;
                    num2 = num1 + 2;
                    num3 = num2 + 2;
                    num4 = num3 + 2;
                    num5 = num4 + 2;
                    num6 = num5 + 2;
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                    Console.WriteLine(num4);
                    Console.WriteLine(num5);
                    Console.WriteLine(num6);
                        
                } else
                {
                    num1 = N;
                    num2 = num1 + 2;
                    num3 = num2 + 2;
                    num4 = num3 + 2;
                    num5 = num4 + 2;
                    num6 = num5 + 2;

                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                    Console.WriteLine(num4);
                    Console.WriteLine(num5);
                    Console.WriteLine(num6);

                }
            }

        }
    }
}
