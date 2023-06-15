using System;
using System.Globalization;

//4) Fazer um programa para ler um vetor de N números reais.Em seguida, mostrar na tela a média aritmética de todos
//elementos.Depois mostrar todos os elementos do vetor que estejam abaixo da média.
//Exemplo:
//Entrada
//4
//10.0 15.5 13.2 9.8

//Saída
//12.125
//10.0
//9.8

namespace expdf_04

{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];
            double soma = 0;
            double media = 0;

            string[] s = Console.ReadLine().Split(' ');

            // Utilizando o 'FOR' para alocar os valores do Vetor 's' no Vetor 'vet'
            //for (int i = 0; i < N; i++)
            //{
            //    vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            //    soma += vet[i];
            //}


            // Utilizando o 'FOREACH' para alocar os valores do Vetor 's' no Vetor 'vet'
            int i = 0;

            foreach (string x in s) // temos que percorrer o vetor string 's' e repassar os valores para o vetor 'vet'
            {
                vet[i]= double.Parse(x, CultureInfo.InvariantCulture);
                soma += vet[i];
                i++;
            }

            media = soma / N;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            // Utilizando o "FOR" para imprimir os elementos abaixo da média

            //for (int i = 0; i < N; i++)
            //{
            //    if (vet[i] < media)
            //    {
            //        Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //}


            // Utilizando o "FOREACH" para imprimir os elementos abaixo da média
            foreach (double x in vet)
            {
                if (x < media)
                {
                    Console.WriteLine(x.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
