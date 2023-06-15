using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ex_1074
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado disponível em: https://www.beecrowd.com.br/judge/pt/problems/view/1074

            int N, x;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                } else if (x > 0)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    } else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                } else
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    } else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }

        }
    }
}
