using System;

//O sargento Silva organiza seu pelotão em M filas numeradas a partir de 1, sendo cada fila com a mesma quantidade de
//soldados. Por exemplo, a figura abaixo mostra a organização do pelotão em 3 filas com 8 soldados em cada uma.

//Um dos exercícios que o sargento Silva realiza com o pelotão é o exercício "girar fila", que consiste em dizer o número
//de uma fila, de modo que os soldados desta fila devem se mover para a direita, e o último soldado da direita vai para a
//posição mais à esquerda. Você deve fazer um programa para ler a formação do pelotão e executar o exercício "girar fila".
//Entrada:
//A entrada consiste em um inteiro M representando o número de filas, um inteiro N representado a quantidade de soldados
//por fila, as M filas de soldados (cada soldado é representado por um número inteiro), e o número inteiro para o exercício
//"girar fila".
//Saída:
//A saída contém a formação do pelotão após a execução do exercício "girar fila".

//Exemplo:
//Entrada
//3
//5
//1034 2271 9013 9281 1138
//2837 1827 1074 9271 7201
//1822 1977 1821 2278 1821
//2

//Saída
//1034 2271 9013 9281 1138
//7201 2837 1827 1074 9271
//1822 1977 1821 2278 1821

namespace expdf_mat07
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());

            int[,] mat1 = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    mat1[i, j] = int.Parse(s[j]);
                }
            }

            int NumFila = int.Parse(Console.ReadLine());

            int[,] mat2 = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                if ( i == NumFila - 1 )
                {
                    for (int j = 0; j < N; j++)
                    {
                        if ( j == 0)
                        {
                            mat2[i, j] = mat1[i, N - 1];
                        } else
                        {
                            mat2[i, j] = mat1[i, j - 1];
                        }
                        Console.Write(mat2[i, j] + " ");
                    }
                    Console.WriteLine();
                } else
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write(mat1[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}