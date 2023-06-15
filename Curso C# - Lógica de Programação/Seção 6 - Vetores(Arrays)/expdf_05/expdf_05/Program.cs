using System;
using System.Globalization;

//5) Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média aritmética somente
//dos números pares lidos.
//Exemplo:
//Entrada
//6
//8 2 11 14 13 20

//Saída
//11.0

namespace expdf_05

{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] s = Console.ReadLine().Split(' ');
            int[] vet = new int[N];

            int i = 0;
            foreach (string x in s)
            {
                vet[i] = int.Parse(x);
                i++;
            }

            double mediaPares;
            int somaPares = 0;

            int contPares = 0;
            foreach (int x in vet)
            {
                if (x % 2 == 0)
                {
                    somaPares += x;
                    contPares++;
                }
            }

            mediaPares = (double) somaPares / contPares;

            Console.WriteLine(mediaPares.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
