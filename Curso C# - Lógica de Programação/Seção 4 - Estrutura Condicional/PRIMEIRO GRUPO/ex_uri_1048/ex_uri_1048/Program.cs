using System;
using System.Globalization;

namespace ex_uri_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em https://www.beecrowd.com.br/judge/pt/problems/view/1048

            double salario, novoSalario, reajuste;
            int reajustePercentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario < 0) 
            {
                Console.WriteLine("valor inválido");
            } else if (salario > 0 && salario <= 400.00)
            {
                reajustePercentual = 15;
                novoSalario = Math.Round(salario * (1 + (reajustePercentual / 100.0)),2);
                reajuste = novoSalario - salario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajustePercentual + " %");

            } else if ( salario <= 800.00)
            {
                reajustePercentual = 12;
                novoSalario = Math.Round(salario * (1 + (reajustePercentual / 100.0)),2);
                reajuste = novoSalario - salario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajustePercentual + " %");

            } else if ( salario <= 1200)
            {
                reajustePercentual = 10;
                novoSalario = Math.Round(salario * (1 + (reajustePercentual / 100.0)), 2);
                reajuste = novoSalario - salario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajustePercentual + " %");

            } else if ( salario <= 2000)
            {
                reajustePercentual = 7;
                novoSalario = Math.Round(salario * (1 + (reajustePercentual / 100.0)), 2);
                reajuste = novoSalario - salario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajustePercentual + " %");
            } else if ( salario > 2000 )
            {
                reajustePercentual = 4;
                novoSalario = Math.Round(salario * (1 + (reajustePercentual / 100.0)), 2);
                reajuste = novoSalario - salario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajustePercentual + " %");
            }

        }
    }
}
