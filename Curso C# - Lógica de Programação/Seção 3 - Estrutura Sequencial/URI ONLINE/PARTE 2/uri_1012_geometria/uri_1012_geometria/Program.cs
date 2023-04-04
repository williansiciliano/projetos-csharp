using System;
using System.Globalization;

namespace uri_1012_geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.
            Entrada
            O arquivo de entrada contém três valores com um dígito após o ponto decimal.

            Saída
            O arquivo de saída deverá conter 5 linhas de dados.Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
            
            Exemplos de Entrada:
            3.0 4.0 5.2

            Exemplos de Saída:
            TRIANGULO: 7.800
            CIRCULO: 84.949
            TRAPEZIO: 18.200
            QUADRADO: 16.000
            RETANGULO: 12.000

             */

            double pi = 3.14159;
            double A, B, C;
            double aTriangulo, aCirculo, aTrapezio, aQuadrado, aRetangulo;
            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture); // base do triangulo; base1 do trapézio; lado1 do retângulo.
            B = double.Parse(vet[1], CultureInfo.InvariantCulture); // base2 do trapézio; lado do quadrado; lado2 do retângulo.
            C = double.Parse(vet[2], CultureInfo.InvariantCulture); // altura do triangulo; raio do círculo; altura do Trapézio

            aTriangulo = (A * C) / 2.0;
            aCirculo = pi * Math.Pow(C, 2.0);
            aTrapezio = ((A + B) / 2.0) * C;
            aQuadrado = Math.Pow(B, 2.0);
            aRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + aTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + aCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + aTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + aQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + aRetangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
