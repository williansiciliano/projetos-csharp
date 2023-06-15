using System;
using System.Globalization;

namespace ex_1073
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado disponível em: https://www.beecrowd.com.br/judge/pt/problems/view/1073

            int N;
            double quadrado;

            N = int.Parse(Console.ReadLine());

            if (N <= 5 || N > 2000)
            {
                Console.WriteLine("Digite um valor entre 5 e 2000");
            } else
            {
                for (int i = 1; i <= N; i++)
                {
                    if (i % 2 == 0)
                    {
                        quadrado = Math.Pow(i, 2);
                        Console.WriteLine(i + "^2 = " + quadrado.ToString("F0", CultureInfo.InvariantCulture));

                    }
                }
            }

        }
    }
}