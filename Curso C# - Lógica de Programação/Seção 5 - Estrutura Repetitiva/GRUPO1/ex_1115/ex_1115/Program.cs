using System;
using System.Globalization;

namespace ex_1115
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1115

            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while ( x != 0 && y != 0 )
            {
                if ( x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                } else if ( x < 0 && y > 0 )
                {
                    Console.WriteLine("segundo");
                } else if ( x < 0 && y < 0 )
                {
                    Console.WriteLine("terceiro");
                } else
                {
                    Console.WriteLine("quarto");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }
    }
}
