using System;
using System.Drawing;
using System.Globalization;


//Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, mandou digitar
//um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de venda das mesmas. Fazer um
//programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
// lucro < 10 %
// 10 % ≤ lucro ≤ 20%
// lucro> 20%
//Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o
//lucro total.

//Exemplo:
//Entrada
//4
//Feijao 10.00 11.00
//Arroz 12.00 12.80
//Oleo 5.00 5.70
//Sal 3.00 4.00

//Saída
//Lucro abaixo de 10%: 1
//Lucro entre 10% e 20%: 2
//Lucro acima de 20%: 1
//Valor total de compra: 30.00
//Valor total de venda: 33.50
//Lucro total: 3.50

namespace expdf_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] produto = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];

            int contLucroAbaixo10 = 0;
            int contLucroEntre10e20 = 0;
            int contLucroAcima20 = 0;
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                produto[i] = s[0];
                precoCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

                if (((precoVenda[i] - precoCompra[i]) / precoCompra[i]) * 100.00 < 10.00)
                {
                    contLucroAbaixo10++;
                } else if ((((precoVenda[i] - precoCompra[i]) / precoCompra[i]) * 100.00 >= 10.00) && (((precoVenda[i] - precoCompra[i]) / precoCompra[i]) * 100.00 <= 20.00))
                {
                    contLucroEntre10e20++;
                } else
                {
                    contLucroAcima20++;
                }  
            }

            Console.WriteLine("Lucro abaixo de 10%: " + contLucroAbaixo10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contLucroEntre10e20);
            Console.WriteLine("Lucro acima de 20%: " + contLucroAcima20);
            double valorTotalCompra = 0;
            for (int i = 0; i < N; i++)
            {
                valorTotalCompra += precoCompra[i];
            }
            Console.WriteLine("Valor total de compra: " +  valorTotalCompra.ToString("F2", CultureInfo.InvariantCulture));

            double valorTotalVenda = 0;
            for (int i = 0; i < N; i++)
            {
                valorTotalVenda += precoVenda[i];
            }
            Console.WriteLine("Valor total de venda: " + valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));

            double lucroTotal = valorTotalVenda - valorTotalCompra;
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
