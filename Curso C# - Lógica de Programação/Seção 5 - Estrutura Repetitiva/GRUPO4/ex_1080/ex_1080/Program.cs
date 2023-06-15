using System;
using System.Globalization;

namespace ex_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado disponível em: https://www.beecrowd.com.br/judge/pt/problems/view/1080

            int x;
            int maior = 0;
            int pos = 0;

            for (int i = 1; i <= 100; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x > maior)
                {
                    maior = x;
                    pos = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(pos);
        }
    }
}
