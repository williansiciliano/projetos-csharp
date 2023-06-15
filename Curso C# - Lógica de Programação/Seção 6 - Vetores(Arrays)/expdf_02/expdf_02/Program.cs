using System;
using System.Globalization;

//Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
//-todos os números pares
//- a quantidade de números pares

//Exemplo:
//Entrada
//6
//8 2 11 14 13 20

//Saída
//8 2 14 20
//4

namespace expdf_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] s = Console.ReadLine().Split(' ');

            int[] vet = new int[N];
            int totalPares = 0;

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
                if (vet[i] % 2 == 0)
                {
                    totalPares++;
                }
            }

            //foreach (int x in vet)
            //{
            //    int i = 0;
            //    vet[x] = int.Parse(s[i]);
            //    i++;
            //}

            foreach (int x in vet)
            {   
                if (x % 2 == 0)
                {
                    Console.Write(x + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine(totalPares);

            //Exercício funcionando corretamente!
        }
    }
}
