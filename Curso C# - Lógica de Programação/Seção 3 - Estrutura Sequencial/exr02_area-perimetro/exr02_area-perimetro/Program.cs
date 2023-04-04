using System;
using System.Drawing;
using System.Globalization;

namespace exr02_area_perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro
            // casas decimais, conforme exemplo.

            double baseRet, alturaRet;
            double area, perimetro, diagonal;

            baseRet = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alturaRet = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = baseRet * alturaRet;
            perimetro = baseRet * 2 + alturaRet * 2;
            diagonal = Math.Sqrt(Math.Pow(baseRet, 2.0) + Math.Pow(alturaRet, 2.0));

            Console.WriteLine();
            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}