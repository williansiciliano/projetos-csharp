using System;
using System.Globalization;

namespace uri_1021_profAlt
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int N_inteiro, quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            N_inteiro = (int)(N * 100.0 + 0.5);

            // Vamos multiplicar N por 100 e forçar a conversão para int(pois o n° de entrada tem 2 casas decimais).
            // Desse modo, por exemplo, 576.73 vai se tornar 57673

            // Vamos tambem somar 0.5 antes de converter, para assegurar 
            // que o numero seja devidamente arredondado, pois o tipo double
            // as vezes da problema de arredondamento (por exemplo: se digitarmos
            // 576.81 e multiplicarmos por 100, o resultado sera 57680.99999999,
            // dai o casting resultaria em 57680 e nao 57681 como desejado)

            // preferível utilizar o Math.Round ==> N_inteiro = (int)Math.Round((N*100))

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = N_inteiro / (nota * 100);
            resto = N_inteiro % (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");


            nota = 50;
            quociente = resto / (nota * 100);
            resto = resto % (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");

            nota = 20;
            quociente = resto / (nota * 100);
            resto = resto % (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");

            nota = 10;
            quociente = resto / (nota * 100);
            resto = resto % (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");

            nota = 5;
            quociente = resto / (nota * 100);
            resto = resto % (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");

            nota = 2;
            quociente = resto / (nota * 100);
            resto = resto % (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");

            Console.WriteLine("MOEDAS:");

            // o valor de cada moeda deverá ser representado em centavos para termos números inteiro em divisão e multip de inteiro por inteiro

            moeda = 100;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");

            moeda = 50;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");

            moeda = 25;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");

            moeda = 10;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");

            moeda = 5;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");

            Console.WriteLine(resto + " moeda(s) de R$ 0.01"); // o resto é completado por moedas de R$ 0,01

        }
    }
}
