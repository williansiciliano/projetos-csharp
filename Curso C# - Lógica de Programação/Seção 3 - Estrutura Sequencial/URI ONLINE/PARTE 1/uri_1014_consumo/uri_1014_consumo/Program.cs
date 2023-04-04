using System;
using System.Globalization;

namespace uri_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X; // distância total percorrida
            double Y; // combustível total gasto
            double consumo;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}