using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace exr03_nome_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler o nome(apenas uma palavra) e idade de duas pessoas. Ao final mostrar uma mensagem com os nomes e a idade média entre essas pessoas,
            // com uma casa decimal, conforme exemplo.

            // Entrada:
            // Maria 19
            // Joaquim 20

            //Saída:
            // A idade média de Maria e Joaquim é de 19.5 anos

            string nome1, nome2;
            int idade1, idade2;
            double media;

            string[] vet1 = Console.ReadLine().Split(' ');
            nome1 = vet1[0];
            idade1 = int.Parse(vet1[1]);

            string[] vet2 = Console.ReadLine().Split(' ');
            nome2 = vet2[0];
            idade2 = int.Parse(vet2[1]);

            media = (double) (idade1 + idade2) / 2.0; // Aplicando o CASTING para transformar o valor de INT para DOUBLE, já que operações com 2 INTS geram outro INT.

            Console.WriteLine();
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos.");

            Console.ReadLine();
        }
    }
}
