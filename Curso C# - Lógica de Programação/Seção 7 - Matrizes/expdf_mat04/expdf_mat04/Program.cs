using System;

//4) Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar a soma dos elementos acima da diagonal principal.
//Entrada:
//A entrada contém o valor N, depois os dados da matriz.
//Saída:
//A saída contém a soma dos elementos da diagonal principal.
//Exemplo:
//Entrada
//3
//10 3 2
//5 15 7
//8 6 4

//Saída
//12

namespace expdf_mat04{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N];

            // Leitura dos elementos da matriz
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            //Percorrer as colunas de cada linha da matriz descobrindo a soma dos elementos acima da diagonal principal
            //Os elementos acima da diagonal principal satisfazem a seguinte condição: considerando que cada elemento sendo mat[i,j], j > i

            int soma = 0;
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if ( j > i )
                    {
                        soma += mat[i, j];
                    }
                }
                
            }
            Console.WriteLine(soma);
        }
    }
}