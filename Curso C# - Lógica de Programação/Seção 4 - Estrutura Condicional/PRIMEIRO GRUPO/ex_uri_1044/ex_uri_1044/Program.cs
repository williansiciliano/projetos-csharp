using System;
using System.Globalization;

namespace ex_uri_1044
{
    class Program
    {
        static void Main(string[] args)
        {

            //Enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1044

            int A, B;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if ( B % A == 0 || A % B == 0)
            {
                Console.WriteLine("Sao Multiplos");
            } else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
    
}
