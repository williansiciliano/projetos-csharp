using System;
using System.Globalization;

namespace ex_1051
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em:https://www.beecrowd.com.br/judge/pt/problems/view/1051

            double salario, impostoRenda;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            } 
            else if (salario > 2000.00 && salario <= 3000.00) {
                impostoRenda = Math.Round(((salario - 2000.00) * 0.08), 2);
                Console.WriteLine("R$ " + impostoRenda.ToString("F2", CultureInfo.InvariantCulture));
            } 
            else if(salario > 3000.00 && salario <= 4500.00)
            {
                impostoRenda = Math.Round((1000.00 * 0.08 + (salario - 3000.00) * 0.18),2);
                Console.WriteLine("R$ " + impostoRenda.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                impostoRenda = Math.Round((1000.00 * 0.08 + 1500.00 * 0.18 + (salario - 4500.00) * 0.28),2);
                Console.WriteLine("R$ " + impostoRenda.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

