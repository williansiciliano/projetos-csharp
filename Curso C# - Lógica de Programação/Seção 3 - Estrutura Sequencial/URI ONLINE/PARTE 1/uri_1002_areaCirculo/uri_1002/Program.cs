using System;
using System.Globalization;

namespace uri_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double π = 3.14159;
            double raio, A;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = π * (Math.Pow(raio, 2.0));

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
