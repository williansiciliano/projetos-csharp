using System;
using System.Globalization;

namespace ex_1060
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1060

            double num1, num2, num3, num4, num5, num6;
            int soma;

            soma = 0;
            num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (num1 > 0.0)
            {
                soma = soma + 1;
            } 

            num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (num2 > 0.0)
            {
                soma = soma + 1;
            }

            num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (num3 > 0.0)
            {
                soma = soma + 1;
            }

            num4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (num4 > 0.0)
            {
                soma = soma + 1; ;
            }

            num5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (num5 > 0.0)
            {
                soma = soma + 1;
            }

            num6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (num6 > 0.0)
            {
                soma = soma + 1;
            }

            Console.WriteLine(soma + " valores positivos");

        }
        
    }
}
