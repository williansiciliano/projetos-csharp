using System;
using System.Globalization;

namespace ex_uri_1041
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em https://www.beecrowd.com.br/judge/pt/problems/view/1041

            double x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if ( x == 0 && y == 0 )
            {
                Console.WriteLine("Origem");
            } else if ( x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            } else if ( x != 0 && y == 0 ) 
            {
                Console.WriteLine("Eixo X");
            } else if ( x > 0 && y > 0 ) 
            {
                Console.WriteLine("Q1");
            } else if ( x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            } else if ( x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            } else
            {
                Console.WriteLine("Q4");
            }

        }
    }
}
