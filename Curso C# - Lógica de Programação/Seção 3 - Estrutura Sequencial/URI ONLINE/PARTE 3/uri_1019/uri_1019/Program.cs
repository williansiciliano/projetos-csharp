﻿using System;
using System.Globalization;

namespace uri_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

                Entrada
                O arquivo de entrada contém um valor inteiro N.

                Saída
                Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
             

                Exemplo de Entrada
                556
                1
                140153

                Exemplo de Saída
                0:9:16
                0:0:1
                38:55:53
            */

            int N; // duração do evento em segundos
            int horas, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;

            minutos = (N % 3600) / 60 ;

            segundos = (N % 3600) % 60;

            Console.WriteLine(horas+":"+minutos+":"+segundos);

        }
    }
}
