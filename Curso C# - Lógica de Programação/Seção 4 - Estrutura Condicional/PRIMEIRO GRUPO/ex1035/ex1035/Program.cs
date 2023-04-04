using System;
using System.Globalization;

namespace ex_uri_1035
{
    class Program
    {
        static void Main (string[] args)
        {

            //Leia 4 valores inteiros A, B, C e D.A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C e D, ambos,
            //forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

            //Entrada
            //Quatro números inteiros A, B, C e D.

            //Saída
            //Mostre a respectiva mensagem após a validação dos valores.

            //Exemplo de Entrada 
            //5 6 7 8

            //2 3 2 6

            //Exemplo de Saída

            //Valores nao aceitos

            //Valores aceitos

            int A, B, C, D;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
                
            } else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}