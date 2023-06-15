using System;
using System.Globalization;

//Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
//do vetor(supor não haver empates).Mostrar também a posição do maior elemento.
//Exemplo:
//Entrada 
//6
//8.0 4.0 10.0 14.0 13.0 7.0

//Saída
//14.0
//3

namespace expdf_01 
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            double maior = 0;
            int posMaior = 0;

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posMaior = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posMaior);

            // Exercício correto!
        }
    }
}