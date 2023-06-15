using System;
using System.Globalization;

namespace ex_1145
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado disponível em: https://www.beecrowd.com.br/judge/pt/problems/view/1145

            int X, Y, iniLinha;
            iniLinha = 1;

            string[] vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            if (X <= 1 || X >= 20 || Y <= X || Y >= 100000)
            {
                Console.WriteLine("X e Y devem satisfazer as seguintes condições: 1 < X < 20; X < Y < 100000");
            } else
            {
                for (int i = 1; i <= (Y/X) + 1; i++) // iterar de 1 a Y / X (número de linhas)
                {
                    for (int j = iniLinha; j <= X*i && j <= Y; j++) // iterar de j (valor de início da linha, somando ao valor do final da linha anterior) a 'x * i ' (valor do final da linha)
                    {
                        if (j < X*i)
                        {
                        Console.Write(j + " ");

                        } else
                        {
                            Console.WriteLine(j);
                            iniLinha = j + 1;
                        }
                    }
                }
            }
        }
    }
}
