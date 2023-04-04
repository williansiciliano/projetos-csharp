using System;
using System.Globalization;

namespace ex_000{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma;

            soma = 0;
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                soma = soma + num;
                num = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(soma);
        }
    }
}

