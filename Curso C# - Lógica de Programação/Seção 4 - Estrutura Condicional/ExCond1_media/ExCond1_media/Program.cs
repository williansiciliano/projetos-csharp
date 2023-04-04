using System;
using System.Globalization;

namespace exCondicional_1_media
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enunaciado: https://www.udemy.com/course/logica-de-programacao-csharp/learn/lecture/7440332#overview

            double nota1, nota2, soma;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            if (soma >= 60.0)
            {
                Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
        }
    }
}