using System;
using System.Globalization;

namespace ex_uri_1038
{
    class Program
    {
        static void Main(string[] args)
        {

            //Enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1038

            int codigo, quantidade;
            double total;

            double preco1 = 4.00;
            double preco2 = 4.50;
            double preco3 = 5.00;
            double preco4 = 2.00;
            double preco5 = 1.50;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    total = (double) (preco1 * quantidade);
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    total = (double) (preco2 * quantidade);
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    total = (double) (preco3 * quantidade);
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    total = (double) (preco4 * quantidade);
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    total = (double) (preco5 * quantidade);
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;


            }
        }
    }
}
