using System;
using System.Globalization;

namespace ex1036
{
    class Program
    {
        static void Main(string[] args)
        {

            //Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes,
            //mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

            //Entrada
            //Leia três valores de ponto flutuante(double) A, B e C.

            //Saída
            //Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular".Caso contrário,
            //imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo.Imprima sempre o final de linha após cada mensagem.

            //Exemplos de Entrada
            //10.0 20.1 5.1

            //Exemplos de Saída
            //R1 = -0.29788
            //R2 = -1.71212

            string[] coeficientes = Console.ReadLine().Split(' ');
            double A, B, C, delta, R1, R2;

            A = double.Parse(coeficientes[0], CultureInfo.InvariantCulture);
            B = double.Parse(coeficientes[1], CultureInfo.InvariantCulture);
            C = double.Parse(coeficientes[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2.0) - 4 * A * C;

            if (delta < 0 || A == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                R1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                R2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }

        }

    }
}
