using System;

namespace expdf_mat05
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] linhaCol = Console.ReadLine().Split(' ');

            M = int.Parse(linhaCol[0]);
            N = int.Parse(linhaCol[1]);

            int[,] matA = new int[M, N];
            int[,] matB = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matA[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matB[i, j] = int.Parse(s[j]);
                }
            }

            int[,] matC = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matC[i, j] = matA[i, j] + matB[i, j];
                    Console.Write(matC[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine(); // para não fechar a janela no final do programa
        }
    }
}

