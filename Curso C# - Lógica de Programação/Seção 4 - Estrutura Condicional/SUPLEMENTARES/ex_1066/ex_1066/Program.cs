using System;
using System.Globalization;

namespace ex_1066
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1066

            int num, contPar, contImpar, contPosi, contNega;

            contPar = 0;
            contImpar = 0;
            contPosi = 0;
            contNega = 0;

            num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    contPar++;
                } 
                if (num % 2 != 0 ) 
                {
                    contImpar++;
                }
                if (num > 0)
                {
                    contPosi++;
                }
                if (num < 0)
                {
                    contNega++;
                }

            num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    contPar++;
                }
                if (num % 2 != 0)
                {
                    contImpar++;
                }
                if (num > 0)
                {
                    contPosi++;
                }
                if (num < 0)
                {
                    contNega++;
                }

            num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    contPar++;
                }
                if (num % 2 != 0)
                {
                    contImpar++;
                }
                if (num > 0)
                {
                    contPosi++;
                }
                if (num < 0)
                {
                    contNega++;
                }

            num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    contPar++;
                }
                if (num % 2 != 0)
                {
                    contImpar++;
                }
                if (num > 0)
                {
                    contPosi++;
                }
                if (num < 0)
                {
                    contNega++;
                }

            num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    contPar++;
                }
                if (num % 2 != 0)
                {
                    contImpar++;
                }
                if (num > 0)
                {
                    contPosi++;
                }
                if (num < 0)
                {
                    contNega++;
                }

            Console.WriteLine(contPar + " valor(es) par(es)");
            Console.WriteLine(contImpar + " valor(es) impar(es)");
            Console.WriteLine(contPosi + " valor(es) positivo(s)");
            Console.WriteLine(contNega + " valor(es) negativo(s)");

        }
    }
}
