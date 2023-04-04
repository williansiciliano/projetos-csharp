using System;
using System.Globalization;

namespace uri_1013_abs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enunciando em https://www.beecrowd.com.br/judge/pt/problems/view/1013

            int A, B, C, MaiorAB, MAIOR;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            MaiorAB = (A + B + Math.Abs(A - B)) / 2;

            MAIOR = (C + MaiorAB + Math.Abs(C - MaiorAB)) / 2;

            Console.WriteLine(MAIOR + " eh o maior");

        }
    }
}
