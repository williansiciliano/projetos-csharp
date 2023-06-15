using System;
using System.Globalization;

namespace expdf_mat06
{
    class Program
    {
        static void Main(string[] args) {
            int N, linhaEscolhida, colunaEscolhida;
            
            // Ler o número N de linhas e colunas (matriz quadrada)
            N = int.Parse(Console.ReadLine());

            double[,] mat = new double[N, N];

            // Ler cada célula da matriz

            double somaPositivos = 0;
            for (int i=0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j=0; j < N; j++)
                {
                    mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);

                    if (mat[i, j] > 0) // fazer uma soma de todos os números positivos da matriz
                    {
                        somaPositivos += mat[i, j];
                    }
                }
            }

            linhaEscolhida = int.Parse(Console.ReadLine());  // Ler o índice da linha escolhida a ter seus elementos apresentados
            colunaEscolhida = int.Parse(Console.ReadLine()); // Ler o índice da coluna escolhida a ter seus elementos apresentados

            Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CultureInfo.InvariantCulture));

            Console.Write("LINHA ESCOLHIDA: ");
            // Percorrer a matriz para imprimir os elementos da LINHA ESCOLHIDA
            for (int i = 0; i < N; i++)
            {
                if ( i == linhaEscolhida)
                {
                    for (int j = 0;  j < N; j++)
                    {
                        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }
            Console.WriteLine();

            Console.Write("COLUNA ESCOLHIDA: ");
            // Percorrer a matriz para imprimir os elementos da COLUNA ESCOLHIDA
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ( j == colunaEscolhida)
                    {
                        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            // Percorrer a matriz para imprimir os elementos da DIAGONAL PRINCIPAL
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA:");
            // Percorrer a matriz para imprimir os ELEMENTOS ELEVADOS AO QUADRADO
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        double negativoSqrt = Math.Pow(mat[i, j], 2.0);
                        Console.Write(negativoSqrt.ToString("F1", CultureInfo.InvariantCulture) + " ");
                    } else
                    {
                        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}