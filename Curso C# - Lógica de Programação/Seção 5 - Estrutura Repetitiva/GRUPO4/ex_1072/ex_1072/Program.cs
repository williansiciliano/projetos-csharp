using System;
using System.Globalization;

namespace ex_1072
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado disponível em: https://www.beecrowd.com.br/judge/pt/problems/view/1072

            int N,x;
            int somaIn = 0;
            int somaOut = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                x = int.Parse(Console.ReadLine());
                if(x >= 10 && x <= 20)
                {
                    somaIn++;
                } else
                {
                    somaOut++;
                }
            }
            Console.WriteLine(somaIn + " in");
            Console.WriteLine(somaOut + " out");
        }
    }
}
