using System;
using System.Globalization;

namespace uri_1015
{
    class Program
    {
        static void Main(string[] args)
        {

            // enunciado disponível em https://www.beecrowd.com.br/judge/pt/problems/view/1015

            double x1, y1, x2, y2;
            double distancia;

            string[] vet1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
