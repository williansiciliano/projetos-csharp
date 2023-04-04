using System;
using System.Globalization;

namespace calculadora_funcao_2grau { 
    class Program { 
        static void Main(string[] args)
        {

            double A, B, C, x, x1, x2, delta, Xv, Yv;

            Console.WriteLine("Considerando uma função do 2° grau no formato y = Ax² + Bx + C, informe os valores de A, B e C (separados por espaço) para calcularmos suas raízes (x1 e x2) :");
            Console.WriteLine("*Use PONTO como separador decimal, se houver necessidade.");
            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Você informou os seguintes coeficientes: ");
            Console.WriteLine("A = " + A.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("B = " + B.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("C = " + C.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("A função a calcular é : y = " + A + "x² + " + B + "x + " + C);
            Console.WriteLine();

            delta = Math.Pow(B, 2.0) - 4 * A * C;

            if (delta < 0)
            {
                Console.WriteLine("Não existem raízes reais!");
            }
            else if (delta == 0)
            {
                x = -B / (2.0 * A);
                Console.WriteLine("Só existe 1 raiz e seu valor é " + x.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (delta > 0)
            {
                x1 = (-B + (Math.Sqrt(delta))) / (2.0 * A);
                x2 = (-B - (Math.Sqrt(delta))) / (2.0 * A);
                Console.WriteLine("Existem 2 raízes e seus valores são: " + x1.ToString("F2", CultureInfo.InvariantCulture) + " e " + x2.ToString("F2", CultureInfo.InvariantCulture));
            }   
                Console.WriteLine();
                Xv = -B / (2.0 * A);
                Yv = -delta / (4.0 * A);
                
                if (Yv == 0) { 
                Yv = Math.Abs(Yv); // para retirar o sinal negativo do "0.00"
                }
                
                Console.WriteLine("O vértice possui as seguintes coordenadas: ");
                Console.WriteLine("Xv = " + Xv.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Yv = " + Yv.ToString("F2", CultureInfo.InvariantCulture));

            
        }
    }
}


