using System;
using System.Globalization;

namespace uri_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, horasTrabalhadas;
            double valorPorHora, salario;

            number = int.Parse(Console.ReadLine());
            horasTrabalhadas= int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
