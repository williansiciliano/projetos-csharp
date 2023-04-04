using System;
using System.Globalization;

namespace ex_uri_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1047

            int horaIni, minIni, horaFinal, minFinal, duracaoHora, duracaoMin;

            string[] vet = Console.ReadLine().Split(' ');
            horaIni = int.Parse(vet[0]);
            minIni = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minFinal = int.Parse(vet[3]);

            int tempoIniMinutos = horaIni * 60 + minIni;
            int tempoFinalMinutos = horaFinal * 60 + minFinal;

            int duracaoMinTotal = tempoFinalMinutos - tempoIniMinutos;

            if (!((horaIni >= 0 && horaIni < 24 ) && (minIni >=0 && minIni < 60) && (horaFinal >= 0 && horaFinal < 24) && (minFinal >= 0 && minFinal < 60)))
            {
                Console.WriteLine("Valores invalidos");
            }
            else
            {

                if (duracaoMinTotal == 0)
                {
                    duracaoHora = 24;
                    duracaoMin = 0;
                }
                else if (duracaoMinTotal < 0)
                {
                    duracaoHora = (24 - horaIni) + horaFinal;

                    if (minIni > minFinal)
                    {
                        duracaoMin = (60 - minIni) + minFinal;
                    }
                    else
                    {
                        duracaoMin = minFinal - minIni;
                    }
                }
                else
                {
                    duracaoHora = duracaoMinTotal / 60;
                    duracaoMin = duracaoMinTotal % 60;
                }

                Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMin + " MINUTO(S)");
            }
        }
    }
}
