using System;
using System.Globalization;

namespace ex_1043 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1043

            double A, B, C;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0],CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2],CultureInfo.InvariantCulture);

            if (( A > Math.Abs(B - C) && A < ( B + C )) || (B > Math.Abs(A - C) && B < (A + C)) || (C > Math.Abs(A - B) && C < (A + B))) 
            { 
                double perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            } else
            {
                double AreaTrapezio = ((A + B) / 2.0) * C;
                Console.WriteLine("Area = " + AreaTrapezio.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}