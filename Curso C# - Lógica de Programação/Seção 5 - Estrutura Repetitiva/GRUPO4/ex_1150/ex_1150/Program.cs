using System;
using System.Globalization;

namespace ex_1150
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado disponível em: https://www.beecrowd.com.br/judge/pt/problems/view/1150

            int X, Z;

            X = int.Parse(Console.ReadLine());
            Z = int.Parse(Console.ReadLine());

            while (Z <= X) // Permanecer digitando um segundo número (para Z) até que este seja: Z > X.
            {
                Z = int.Parse(Console.ReadLine());
            }

            // Neste ponto já temos um X e Z tal que Z > X ... 

            int soma = X;
            int quantidadeNumeros = 1;

            for (int i = 1; soma < Z; i++)
            {
                soma = soma + (X + i);  // soma = X + (X+1) .... soma = 3 + ( 3 + 1) = 7.... soma = 7 + (3 + 2) = 
                quantidadeNumeros++;
            }

            Console.WriteLine(quantidadeNumeros);
        
        }
    }
}
