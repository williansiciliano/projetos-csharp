using System;
using System.Globalization;
using System.Linq.Expressions;

//3) Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde
//cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima o vetor C gerado.

//Exemplo:
//Entrada
//6
//8 2 11 14 13 20
//5 10 3 1 10 7

//Saída
//13 12 14 15 23 27

namespace expdf_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            string[] s1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(s1[i]);
            }

            string[] s2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(s2[i]);
            }


            for (int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
            }

            foreach (int x in C)
            {
                Console.Write(x + " ");
            }
        }
    }
}


