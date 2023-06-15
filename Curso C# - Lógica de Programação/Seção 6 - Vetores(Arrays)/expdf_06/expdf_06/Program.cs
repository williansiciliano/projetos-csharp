using System;
using System.Globalization;

//6) Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois, mostrar na tela o nome
//da pessoa mais velha.
//Exemplo:
//Entrada
//5
//Joao 16
//Maria 21
//Teresa 15
//Carlos 23
//Paulo 17

//Saída
//Pessoa mais velha: Carlos

namespace expdf_05

{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            
            // criar um vetor para cada coluna (nomes e idades)
            string[] nomes = new string[N]; 
            int[] idades = new int[N];

            // atribuir o valor do nome e idade digitado em cada linha (string) para os vetores 'nomes' e 'idades'
            for ( int i = 0; i < N; i++) 
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }

            // Descobrir, através da iteração percorrendo o vetor idade, qual é a maior idade
            int maiorIdade = 0;
            foreach (int x in idades)
            {
                if (x >= maiorIdade)
                {
                    maiorIdade = x;
                }
            }

            // Definido o valor da 'maiorIdade', vamos saber quantos valores desta existe
            int contMaiorIdade = 0;
            foreach (int x in idades)
            {
                if (x == maiorIdade)
                {
                    contMaiorIdade++;
                }
            }

            // Descobrindo quantas pessoas há com a 'maiorIdade' informada
            if (contMaiorIdade == 1) // Se houver apenas 1 pessoa, retornar um tipo de informação
            {   
                int j = 0;
                foreach (int x in idades)
                {
                    if (x == maiorIdade)
                    {
                        Console.WriteLine("Pessoa mais velha: " + nomes[j]);
                    }
                    j++;
                }
            }
            else //  Senão (contMaiorIdade > 1), retornar outro tipo de informação
            {
                int k = 0;
                foreach (int x in idades)
                {
                    if (x == maiorIdade)
                    {
                        Console.WriteLine(nomes[k] + " é uma das pessoas com a maior idade.");
                    }
                    k++;
                }
            }


        }
    }
}

