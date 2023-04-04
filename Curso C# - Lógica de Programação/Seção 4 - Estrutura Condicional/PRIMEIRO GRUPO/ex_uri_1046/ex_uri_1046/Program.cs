using System;
using System.Globalization;

namespace ex_uri_1046
{
    class Program
    {
        static void Main(string[] args)
        {

            //Enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1046

            int horaIni, horaFinal, duracao;

            string[] vet = Console.ReadLine().Split(' ');
            horaIni = int.Parse(vet[0]); 
            horaFinal = int.Parse(vet[1]);

            if (!((horaIni >= 0 && horaIni < 24) && (horaFinal >= 0 && horaFinal < 24)))
            {
                Console.WriteLine("Valores invalidos");
            } else if ( horaFinal > horaIni)
            {
                duracao = horaFinal - horaIni;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            } else if ( horaFinal < horaIni)
            {
                duracao = (24 - horaIni) + horaFinal;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            } else if ( horaFinal ==  horaIni )
            {
                duracao = 24;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }

        }
    }

}
