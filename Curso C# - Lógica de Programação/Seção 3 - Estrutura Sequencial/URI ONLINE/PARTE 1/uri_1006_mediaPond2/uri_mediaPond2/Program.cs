using System;
using System.Globalization;

namespace uri_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((A * 2.0) + (B * 3.0) + (C * 5.0))/10.0;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
