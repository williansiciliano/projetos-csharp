using System;
using System.Globalization;

namespace exr01_area_terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex: Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma casa decimal, bem como o valor do metro quadrado do
                terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com duas
                casas decimais, conforme exemplo.

            Exemplo:
            Entrada:
            10.0
            30.0
            200.00

            Saída:
            AREA = 300.00
            PRECO = 60000.00
            */

            double largura, comprimento, valorMetroQuadrado, area, preco;

            /* MéTODO DE LEITURA DIGITANDO OS DADOS TODOS EM 1 LINHA SÓ E ALOCANDO-OS EM UM VETOR:
            Console.WriteLine("Vamos calcular a área e o preço de um terreno! Para isso informe a largura, comprimento e o valor do m² do terreno, separando as 3 informações por espaços:");
            string[] vet = Console.ReadLine().Split(' ');
            largura = double.Parse(vet[0]);
            comprimento = double.Parse(vet[1]);
            valor_metragem = double.Parse(vet[2]);
            */

            Console.WriteLine("Vamos calcular a área e o preço de um terreno! Para isso informe a largura, o comprimento e o valor do m² do terreno: ");

            Console.WriteLine();
            Console.WriteLine("Digite o valor da largura: ");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o valor do comprimento: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o valor do m² do terreno: ");
            valorMetroQuadrado = double.Parse(Console.ReadLine());

            largura = Math.Round(largura, 1);
            comprimento = Math.Round(comprimento, 1);
            valorMetroQuadrado = Math.Round(valorMetroQuadrado, 2);

            Console.WriteLine();
            Console.WriteLine("Você informou os seguintes dados:");
            Console.WriteLine("Largura = " + largura.ToString("F1") + "m");
            Console.WriteLine("Comprimento = " + comprimento.ToString("F1") + "m");
            Console.WriteLine("Valor do m² = R$" + valorMetroQuadrado.ToString("F2") + "/m²");

            area = largura * comprimento;
            preco = area * valorMetroQuadrado;

            Console.WriteLine();
            Console.WriteLine("Os resultados são: ");
            Console.WriteLine("Área = " + area.ToString("F2") + "m²");
            Console.WriteLine("Preço = " + preco.ToString("C")); // APARECER EM FORMATO MOEDA LOCAL!


        }
    }
}
