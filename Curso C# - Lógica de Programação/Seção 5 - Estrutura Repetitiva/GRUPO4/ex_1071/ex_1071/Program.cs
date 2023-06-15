using System;
using System.Globalization;

namespace ex_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1071

            int X, Y, NumMin, NumMax;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                NumMax = X;
                NumMin = Y;
            } else
            {
                NumMax = Y;
                NumMin = X;
            }

            int soma = 0; 

            for (int i = NumMin+1; i < NumMax; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i; 
                }
            }

            Console.WriteLine(soma);
            
        }
    }
}