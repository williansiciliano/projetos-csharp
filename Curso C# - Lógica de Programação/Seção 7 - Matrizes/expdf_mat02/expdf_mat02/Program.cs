using System;

//2) Ler um número N e depois uma matriz quadrada NxN com números inteiros.Depois, mostrar na tela a soma dos
//elementos de cada linha da matriz.
//Entrada:
//A entrada contém o número N, depois os dados da matriz.
//Saída:
//A saída contém os números representando a soma dos elementos de cada linha da matriz.

//Exemplo:
//Entrada
//3
//5 2 4
//10 3 6
//9 8 12

//Saída
//11
//19
//29

namespace expdf_mat02
{

    class Program
    {
        static void Main(string[] args) 
        {
            int N;
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < N; j++)
                {
                    somaLinha += mat[i, j];
                }
                Console.WriteLine(somaLinha);
            }


        }
    }
}