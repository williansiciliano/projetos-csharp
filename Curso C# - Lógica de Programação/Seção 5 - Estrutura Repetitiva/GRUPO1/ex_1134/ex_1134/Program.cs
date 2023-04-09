using System;
using System.Globalization;

namespace ex_1134
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1134

            int code, contAlcool, contGas, contDiesel;
            
            contAlcool = 0;
            contGas = 0;
            contDiesel = 0;
            code = int.Parse(Console.ReadLine());

            while ( code != 4 )
            {
                if ( code == 1 )
                {
                    contAlcool = contAlcool + 1;
                    code = int.Parse(Console.ReadLine());
                } else if ( code == 2 )
                {
                    contGas = contGas + 1;
                    code = int.Parse(Console.ReadLine());
                } else if ( code == 3 )
                {
                    contDiesel += 1;
                    code = int.Parse(Console.ReadLine());
                } else
                {
                    code = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + contAlcool);
            Console.WriteLine("Gasolina: " + contGas);
            Console.WriteLine("Diesel: " + contDiesel);

        }
    }
}


