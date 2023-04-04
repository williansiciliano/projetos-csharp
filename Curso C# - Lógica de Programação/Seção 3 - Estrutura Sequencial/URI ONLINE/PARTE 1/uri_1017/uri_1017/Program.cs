using System;
using System.Globalization;

namespace uri_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            // calcular e mostrar a quantidade de litros de combustível gastos em uma viagem
            // um automóvel que faz 12 KM/L
            // fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h)
            // Assim, pode-se obter distância percorrida e, em seguida, calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto.

            double horas, velocidadeMedia;
            double distancia, litrosCombustivel;

            // distancia = velocidadeMedia x horas
            // rendimento = 12 [KM/L] = distancia / litrosCombustivel ==> litrosCombustivel = distancia / 12 [KM/L]

            horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            velocidadeMedia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            distancia = horas * velocidadeMedia;

            litrosCombustivel = distancia / 12.0;

            Console.WriteLine(litrosCombustivel.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
