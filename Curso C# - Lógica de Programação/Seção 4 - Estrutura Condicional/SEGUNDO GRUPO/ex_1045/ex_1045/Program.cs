using System;
using System.Globalization;

namespace ex_uri_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em https://www.beecrowd.com.br/judge/pt/problems/view/1045

            double A, B, C, n1, n2, n3;
            string[] vet = Console.ReadLine().Split(' ');

            // Forma mais fácil pelo Método Array.Sort e Array.Reverse

            // Array.Sort(vet);
            // Array.Reverse(vet);

            // A = double.Parse(vet[0]);
            // B = double.Parse(vet[1]);
            // C = double.Parse(vet[2]);

            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (n1 > n2 && n1 > n3)
            {
                A = n1;
                if (n2 > n3)
                {
                    B = n2; C = n3;
                }
                else
                {
                    B = n3; C = n2;
                }
            } else if ( n2 > n1 && n2 > n3) 
            {
                A = n2;            
                if (n1 > n3)
                {
                    B = n1; C = n3;
                } else
                {
                    B = n3; C = n1;
                }

            } else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1; C = n2;
                } else
                {
                    B = n2; C = n1;
                }
            }

            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine(C);

            // Até aqui determinarmos, manualmente e por pura lógica de programação com COndicionais, os valores de A, B e C, de modo que A > B > C.

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            } else if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            } else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            } else
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            } 
            
            if (A == B && A == C )
            {
                Console.WriteLine("TRIANGULO EQUILATERO");

            } else if ( (A == B && A != C) || (A == C && A != B) || ( B == C && B != A ) ) 
            { 
                Console.WriteLine("TRIANGULO ISOSCELES");
            } 
        }
    }
}
