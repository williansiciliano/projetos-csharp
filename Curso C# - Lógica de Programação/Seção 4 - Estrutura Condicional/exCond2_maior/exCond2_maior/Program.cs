using System;
using System.Globalization;

namespace exCond2_menorNum
{
    class Program
    {
        static void Main(string[] args)
        {

            //Leia 3 números inteiros e mostre o menor. Em caso de números iguais, não repetir.

            int A, B, C, menor;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            if (A < B && A < C)
            {
                menor = A;
            }
            else if (B < A && B < C)
            {
                menor = B;
            } else
            {
                menor = C;
            }
            Console.WriteLine("MENOR = " + menor);
        }

    }
}
