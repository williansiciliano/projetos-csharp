using System;
using System.Globalization;

namespace ex_1131
{
    class Program
    {
        static void Main(string[] args)
        {

            int golsInter, golsGremio, codigo, grenais;
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            grenais = 0;

            string[] placar = Console.ReadLine().Split(' ');
            golsInter = int.Parse(placar[0]);
            golsGremio = int.Parse(placar[1]);

            grenais = grenais + 1;

            if (golsInter > golsGremio)
            {
                vitoriasInter = vitoriasInter + 1;
            }
            else if (golsInter < golsGremio)
            {
                vitoriasGremio = vitoriasGremio + 1;
            }
            else
            {
                empates = empates + 1;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            codigo = int.Parse(Console.ReadLine());

            while (codigo != 1 && codigo != 2)
            {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
            }

            while (codigo == 1)
            {
                placar = Console.ReadLine().Split(' ');
                golsInter = int.Parse(placar[0]);
                golsGremio = int.Parse(placar[1]);

                if (golsInter > golsGremio)
                {
                    vitoriasInter = vitoriasInter + 1;
                } else if (golsInter < golsGremio)
                {
                    vitoriasGremio = vitoriasGremio + 1;
                } else
                {
                    empates = empates + 1;
                }

                grenais = grenais + 1;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);

            if ( vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            } else if ( vitoriasInter < vitoriasGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            } else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}

