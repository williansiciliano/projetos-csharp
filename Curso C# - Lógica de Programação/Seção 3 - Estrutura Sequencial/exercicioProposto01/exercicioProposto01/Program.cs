using System;
using System.Globalization;

namespace entrada_de_dados2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
            Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela:
             
            Entre com o seu nome completo:
            < Alex Green >
            Quantos quartos tem sua casa?
            < 3 >
            Entre com o preço de um produto:
            < 500.50 >
            Entre com seu último nome, idade e altura (mesma linha separados por espaço):
            < Green 21 1.73 >
             
             */

            /*
             SAÍDA ESPERADA(NÚMEROS REAIS COM 2 CASAS DECIMAIS):
            Alex Green
            3
            500.50
            Green
            21
            1.73

             */

            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa? ");
            int numeroQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha separados por espaço): ");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(numeroQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
