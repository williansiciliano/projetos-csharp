using System;
using System.Globalization;

namespace ex_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em:https://www.beecrowd.com.br/judge/pt/problems/view/1049

            string grupo1, grupo2, grupo3;

            grupo1 = Console.ReadLine();
            grupo2 = Console.ReadLine();
            grupo3 = Console.ReadLine();

            if (grupo1 == "vertebrado")
            {
                if (grupo2 == "ave")
                {
                    if (grupo3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    } else
                    {
                        Console.WriteLine("pomba");
                    }
                } else
                {
                    if (grupo3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    } else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            } else
            {
                if (grupo2 == "inseto")
                {
                    if (grupo3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    } else
                    {
                        Console.WriteLine("lagarta");
                    }
                } else
                {
                    if (grupo3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    } else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
