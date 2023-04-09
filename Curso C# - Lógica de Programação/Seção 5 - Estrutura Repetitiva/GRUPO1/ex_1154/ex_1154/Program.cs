using System;
using System.Globalization;

namespace ex_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1154

            int idade, soma, cont;
            double media;

            idade = int.Parse(Console.ReadLine());
            soma = 0;
            cont = 0;

            while ( idade >= 0 )
            {
                cont++;
                soma = soma + idade;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}



