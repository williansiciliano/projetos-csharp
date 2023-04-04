using System;
using System.Globalization;

namespace ex_1065
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1065

            int num, cont;

            cont = 0;
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                cont++;
            }
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                cont++;
            }
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                cont++;
            }
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                cont++;
            }
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                cont++;
            }

            Console.WriteLine(cont + " valores pares");
        }
    }
}
