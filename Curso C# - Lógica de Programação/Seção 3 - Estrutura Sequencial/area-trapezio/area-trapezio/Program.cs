using System;
using System.Globalization;

namespace area_trapezio
{
    class Program
    {
        static void Main(string[] args)
        {

            double b, B, h, area;

            b = 6.0; // quando usarmos DOUBLE, convém escrever o ".0" para indicar que não se trata de um n° inteiro. Se fosse FLOAT usaríamos "6f" no lugar de "6.0"
            B = 8.0;
            h = 5.0;

            area = (B + b) / 2.0 * h; // se fosse FLOAT, usaríamos "2f" no lugar de "2.0"

            Console.WriteLine(area);
            

            Console.ReadLine();
        }
    }
}
