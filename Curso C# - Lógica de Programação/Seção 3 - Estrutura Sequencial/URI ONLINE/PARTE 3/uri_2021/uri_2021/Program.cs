using System;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace uri_2021
{
    class Program
    {
        private static int tr;

        static void Main(string[] args)
        {
            /*
             Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

            Entrada
            O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

            Saída
            Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

            Obs: Utilize ponto (.) para separar a parte decimal.
             
            Exemplo de Entrada
            576.73

            Exemplo de Saída
            NOTAS:
            5 nota(s) de R$ 100.00
            1 nota(s) de R$ 50.00
            1 nota(s) de R$ 20.00
            0 nota(s) de R$ 10.00
            1 nota(s) de R$ 5.00
            0 nota(s) de R$ 2.00
            MOEDAS:
            1 moeda(s) de R$ 1.00
            1 moeda(s) de R$ 0.50
            0 moeda(s) de R$ 0.25
            2 moeda(s) de R$ 0.10
            0 moeda(s) de R$ 0.05
            3 moeda(s) de R$ 0.01
             
             */

            double N;
            int reais, centavos;
            int cemReais, cinquentaReais, vinteReais, dezReais, cincoReais, doisReais;
            int umReal, cinquentaCent, vinteCincoCent, dezCent, cincoCent, umCent;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = N.ToString("F2").Split(','); // importantíssimo colocar o "F2", senão não haverá a posição [1] do vetor se o valor tiver zero após o separador decimal!!! Ex: 4.00
            reais = int.Parse(vet[0]);
            centavos = int.Parse(vet[1]);

            cemReais = reais / 100;
            cinquentaReais = (reais % 100) / 50;
            vinteReais = ((reais % 100) % 50) / 20;
            dezReais = (((reais % 100) % 50) % 20) / 10;
            cincoReais = ((((reais % 100) % 50) % 20) % 10) / 5;
            doisReais = (((((reais % 100) % 50) % 20) % 10) % 5) / 2;

            umReal = (((((reais % 100) % 50) % 20) % 10) % 5) % 2;

            cinquentaCent = centavos / 50;
            vinteCincoCent = (centavos % 50) / 25;
            dezCent = ((centavos % 50) % 25) / 10;
            cincoCent = (((centavos % 50) % 25) % 10) / 5;
            umCent = (((centavos % 50) % 25) % 10) % 5;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(cemReais + " nota(s) de R$ 100.00");
            Console.WriteLine(cinquentaReais + " nota(s) de R$ 50.00");
            Console.WriteLine(vinteReais + " nota(s) de R$ 20.00");
            Console.WriteLine(dezReais + " nota(s) de R$ 10.00");
            Console.WriteLine(cincoReais + " nota(s) de R$ 5.00");
            Console.WriteLine(doisReais + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(umReal + " moeda(s) de R$ 1.00");
            Console.WriteLine(cinquentaCent + " moeda(s) de R$ 0.50");
            Console.WriteLine(vinteCincoCent + " moeda(s) de R$ 0.25");
            Console.WriteLine(dezCent + " moeda(s) de R$ 0.10");
            Console.WriteLine(cincoCent + " moeda(s) de R$ 0.05");
            Console.WriteLine(umCent + " moeda(s) de R$ 0.01");

            // O programa funciona, só não está sendo aceito pela URI, com a seguinte mensagem:
            /*
            RUNTIME ERROR -DICAS
            Sua solução recebeu Runtime Error provavelmente por uma das seguintes causas:

                        Você tentou acessar uma variável não definida;
                        Você definiu um array ou vetor com menos capacidade que o requisitado pelo problema;
                        Você está tentando acessar uma posição inválida em memória.
            Preste atenção a descrição do problema e atente para sua solução para corrigí - la!
            */

            
        }
    }
}