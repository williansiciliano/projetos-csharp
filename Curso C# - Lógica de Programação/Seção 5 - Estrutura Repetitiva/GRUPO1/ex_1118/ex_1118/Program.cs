using System;
using System.Globalization;

namespace ex_1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1, X2, media;

            X1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (X1 < 0 || X1 > 10)
            {
                Console.WriteLine("nota invalida");
                X1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            X2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (X2 < 0 || X2 > 10)
            {
                Console.WriteLine("nota invalida");
                X2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (X1 + X2) / 2.0;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("novo calculo (1-sim 2-nao)");

            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 1 && codigo != 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                codigo = int.Parse(Console.ReadLine());
            }

            while ( codigo == 1 )
            {
                X1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (X1 < 0 || X1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    X1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                X2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (X2 < 0 || X2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    X2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (X1 + X2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");

                codigo = int.Parse(Console.ReadLine());

                while (codigo != 1 && codigo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    codigo = int.Parse(Console.ReadLine());
                }
            }

        }
    }
}
