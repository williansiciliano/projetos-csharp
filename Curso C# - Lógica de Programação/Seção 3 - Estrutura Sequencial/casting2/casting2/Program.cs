using System;
using System.Globalization;

namespace casting2 {
    class Program
    {
        static void Main(string[] args)
        {

            double a;
            int b;

            a = 5.0;
            b = (int)a; // Quando atribuímos um valor do tipo DOUBLE a uma variável INT há uma perda de informação. Temos que avisar ao compilador que não nos importamos com esta perda de informação.
                        // CASTING = conversão explícita de um tipo para outro
            Console.WriteLine(b); // Dessa forma, o compilador permite que o programa seja compilado sem apresentar o erro de falha na conversão implícita de tipos

            Console.ReadLine();
        }
    }

}
