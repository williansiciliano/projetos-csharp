using System;
using System.Globalization;

//7) Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres.
//Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados,
//considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.
//Exemplo:
//Entrada
//4
//Joao 7.0 8.5
//Maria 9.2 6.5
//Carlos 5.0 6.0
//Teresa 5.5 6.5

//Saída
//Alunos aprovados:
//Joao
//Maria
//Teresa

namespace expdf_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] nomes = new string[N];
            double[] notas1 = new double[N];
            double[] notas2 = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                notas1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                notas2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados:");

            double[] medias = new double[N];

            for (int i = 0;i < N; i++)
            {
                medias[i] = (notas1[i] + notas2[i]) / 2;
                if (medias[i] >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}

//Exercício concluído com sucesso!
