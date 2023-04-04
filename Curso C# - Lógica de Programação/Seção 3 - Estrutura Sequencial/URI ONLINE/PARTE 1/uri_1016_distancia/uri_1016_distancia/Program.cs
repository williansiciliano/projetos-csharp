using System;
using System.Globalization;

namespace uri_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            // carroX e carroY
            // vX = 60km/h; vY = 90km/h
            //Calcular distancia entre eles em KM em função do tempo em Minutos

            // velocidade constante do carroX em KM/MINUTO (60km/h)                   60 Km ---- 60min     60Km.min = xKm.60min  =>  x Km = 60Km.1min/60min   
            //                                                                         x Km ---- 1 min                               x Km = 1 Km (vX = 1km/min)
            // vX = 1 km/min


            // velocidade constante do carroY em KM/MINUTO                            90 km ---- 60min    90 km.min = xkm.60min -->  x km = 90km.1min/60min
            //                                                                         x Km ---- 1 min                               x km = 1.5 Km (vY = 1.5km/min)
            // vY = 1.5 Km/min


            // vX = 1;
            // vY = 1.5;
            double distancia, tempo;

            // distancia = 1.5tempo - 1tempo ==> distancia = 0.5tempo
            // tempo(min) = 2distancia(km)

            distancia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tempo = 2.0 * distancia;

            Console.WriteLine(tempo.ToString("F0", CultureInfo.InvariantCulture) + " minutos");
            
        }
    }
}