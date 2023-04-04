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

            int duracaoMinTotal;

            if (tempoIniMinutos >= tempoFinalMinutos) // incluindo o "=" --> se os dados de entrada forem "0 0 0 0", a duração será 24h
            {
                duracaoMinTotal = (24 * 60 - tempoIniMinutos) + tempoFinalMinutos;
            } else
            {
                duracaoMinTotal = tempoFinalMinutos - tempoIniMinutos;
            }

            duracaoHora = duracaoMinTotal / 60;
            duracaoMin = duracaoMinTotal % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMin + " MINUTO(S)");
        }
    }
}