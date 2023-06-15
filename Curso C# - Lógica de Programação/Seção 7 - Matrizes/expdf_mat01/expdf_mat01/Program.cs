using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace expdf_mat01
{

//1) Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo.Em seguida, mostrar
//na tela somente os números negativos da matriz.
//Entrada:
//A entrada contém os números M e N na mesma linha, depois os dados da matriz.
//Saída:
//A saída contém uma mensagem e depois os números negativos da matriz, conforme exemplo.

//Exemplo:
//Entrada
//2 3
//12 -8 5
//-13 10 -6

//Saída
//VALORES NEGATIVOS:
//-8
//-13
//-6

    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);
            int[,] mat = new int[M, N]; // declarando e instanciando a matriz ao mesmo tempo

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' '); // não preciso declarar novamente que é um vetor de string (já foi feito na LINHA 32)
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }

        }
    }
}