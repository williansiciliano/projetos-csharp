using System;
using System.Globalization;

namespace entrada_de_dados2 {
    class Program {
        static void Main(string[] args) {

            // Ler no Console:
            /* 
            35
            F
            4.32
            Maria F 23 1.68
             */

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); /* Como o nosso PC está em PT-BT, teríamos que usar a VÍRGULA como
                                                                                         * SEPARADOR DECIMAL na hora de digitar. OU digitar 'CultureInfo.InvariantCulture'.*/

            // //Agora vamos ler 4 valores separados por espaços e armazenar cada um deles em uma variável(usar o comando SPLIT em um VETOR):
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture); // Assim pegará o número que digitamos com o ponto sem apresentar erro.

            Console.WriteLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture)); // Fará aparecer o PONTO como SEPARADOR DECIMAL
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
