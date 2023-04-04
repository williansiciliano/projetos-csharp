using System;
using System.Globalization;

namespace casting {
    class Program { 
        static void Main(string[] args) {

            int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = (double) a / b; // quando dividmos um inteiro por outro, o resultado será inteiro, ainda que a variável seja DOUBLE.
                                        // Então, para converter temos que a fazer um CASTING.

            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}

