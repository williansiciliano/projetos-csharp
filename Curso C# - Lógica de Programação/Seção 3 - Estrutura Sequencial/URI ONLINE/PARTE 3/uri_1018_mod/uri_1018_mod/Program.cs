using System;
using System.Globalization;

namespace uri_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. 
                As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

                Entrada
                O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

                Saída
                Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. 
                Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.

                Exemplo de Entrada
                576

                Exemplo de Saída
                576
                5 nota(s) de R$ 100,00
                1 nota(s) de R$ 50,00
                1 nota(s) de R$ 20,00
                0 nota(s) de R$ 10,00
                1 nota(s) de R$ 5,00
                0 nota(s) de R$ 2,00
                1 nota(s) de R$ 1,00
                
            */

            int N;
            int cem, cinquenta, vinte, dez, cinco, dois, um;

            N = int.Parse(Console.ReadLine());

            cem = N / 100;
            cinquenta = (N % 100) / 50;
            vinte = ((N % 100) % 50) / 20;
            dez = (((N % 100) % 50) % 20) / 10;
            cinco = ((((N % 100) % 50) % 20) % 10) / 5;
            dois = (((((N % 100) % 50) % 20) % 10) % 5) / 2;
            um = (((((N % 100) % 50) % 20) % 10) % 5) % 2;

            Console.WriteLine(N);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");

        }
    }
}
