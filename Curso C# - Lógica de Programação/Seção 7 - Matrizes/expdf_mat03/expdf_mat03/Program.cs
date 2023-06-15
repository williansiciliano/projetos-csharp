using System;

//3) Ler um inteiro N e uma matriz quadrada de ordem N.Mostrar qual o maior elemento de cada linha.Suponha não haver
//empates.
//Entrada:
//A entrada contém o número N, depois os dados da matriz.
//Saída:
//A saída contém os números representando o maior elemento de cada linha da matriz.
//Exemplo:
//Entrada
//4
//10 5 12 3
//4 7 0 6
//3 3 8 1
//15 13 4 7

//Saída
//12
//78
//15

namespace expdf_mat03
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
                int maiorLinha = 0;
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > maiorLinha)
                    {
                        maiorLinha = mat[i, j];
                    }
                }
                Console.WriteLine(maiorLinha);
            }
        }
    }
}