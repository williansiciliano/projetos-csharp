using System;
using System.Globalization;

namespace ex_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado disponível em: https://www.beecrowd.com.br/judge/pt/problems/view/1099

            int N, X, Y, max, min;
            

            N = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= N; i++ ) // Laço para estabelecer número de testes e em cada um ler o par de números X e Y, estabelecendo 'min' e 'max'
            {
                int somaImpar = 0; // Sempre que voltar para um novo 'i', 'somaImpar' zera!
                string[] vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (Y > X)
                {
                    min = X;
                    max = Y;

                    for (int j = min + 1; j < max; j++) // Laço para iterar entre os números 'min' e max' (X e Y), incluindo na 'somaImpar' os números ímpares do intervalo
                    {
                        if (j % 2 != 0)
                        {
                            somaImpar = somaImpar + j;
                        }
                    }
                } else if (Y < X || Y == X) 
                {
                    min = Y;
                    max = X;
                    for (int j = min + 1; j < max; j++) // Laço para iterar entre os números 'min' e max' (Y e X), incluindo na 'somaImpar' os números ímpares do intervalo 
                    { // se Y = X, começará com j = min + 1 (j > max; não satisfazendo a condição do FOR, então, pulará para fora do bloco, não somando nada (somaImpar = 0)
                        if (j % 2 != 0)
                        {
                            somaImpar = somaImpar + j;
                        }
                    }
                }

                Console.WriteLine(somaImpar);
            }
        }
    }
}
