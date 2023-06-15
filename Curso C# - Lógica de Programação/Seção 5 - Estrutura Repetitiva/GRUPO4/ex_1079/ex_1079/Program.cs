using System;
using System.Globalization;

namespace ex_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado disponível em: https://www.beecrowd.com.br/judge/pt/problems/view/1079

            int N;
            double x1, x2, x3, mediaPond;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x1 = double.Parse(vet[0], CultureInfo.InvariantCulture); // não esquecer de colocar "CultureInfo.InvariantCulture" pois o valor da variável estava x10
                x2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                x3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                mediaPond = ((x1 * 2.0) + (x2 * 3.0) + (x3 * 5.0))/10.0;
                Console.WriteLine(mediaPond.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}

