using System;
using System.Globalization;

namespace ex_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado disponível em: https://www.beecrowd.com.br/judge/pt/problems/view/1101

            int M, N, min, max;

            string[] vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);

            while (M > 0 && N > 0) {
                int soma = 0;

                    if (M <= N )
                    {
                        min = M; max = N;
                    } else
                    {
                        min = N; max = M;
                    }

                    for(int i = min; i <= max; i++)
                    {
                        Console.Write(i + " ");
                        soma = soma + i;
                    }
                    Console.WriteLine("Sum=" + soma);
                    vet = Console.ReadLine().Split(' ');
                    M = int.Parse(vet[0]);
                    N = int.Parse(vet[1]);
            }
        }
    }
}
