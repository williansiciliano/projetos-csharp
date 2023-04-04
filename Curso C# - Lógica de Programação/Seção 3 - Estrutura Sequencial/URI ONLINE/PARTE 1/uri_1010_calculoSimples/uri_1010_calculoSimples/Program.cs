using System;
using System.Globalization;

namespace uri_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, numPecas1, codigo2, numPecas2;
            double valorUnit1, valorUnit2, valorPagar;

            string[] vet1 = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet1[0]);
            numPecas1= int.Parse(vet1[1]);
            valorUnit1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet2[0]);
            numPecas2 = int.Parse(vet2[1]);
            valorUnit2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            valorPagar = numPecas1 * valorUnit1 + numPecas2 * valorUnit2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));    

        }
    }
}
