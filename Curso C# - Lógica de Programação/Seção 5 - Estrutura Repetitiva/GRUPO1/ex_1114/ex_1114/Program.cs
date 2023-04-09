using System;
using System.Globalization;

namespace ex_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1114

            int senha;

            senha = int.Parse(Console.ReadLine());

            while (senha != 2002 )
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
