using System;
using System.Globalization;

namespace ex_1159
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1159

            int X;
            int somaPar;

            X = int.Parse(Console.ReadLine());

            while (X != 0)
            {
                if (X % 2 == 0)
                {
                    somaPar = X + (X + 2) + (X + 4) + (X + 6) + (X + 8);
                } else
                {
                    somaPar = (X + 1) + (X + 3) + (X + 5) + (X + 7) + (X + 9);
                }
                Console.WriteLine(somaPar);
                X = int.Parse(Console.ReadLine());

            }
            
        }
    }
}
