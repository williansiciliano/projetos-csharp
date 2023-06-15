using System;
using System.Globalization;
using System.Security.AccessControl;

//Tem - se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas. Fazer um programa que calcule e escreva:
// a maior e a menor altura do grupo
// a média de altura das mulheres
// o número de homens

//Exemplo:
//Entrada
//5
//1.70 F
//1.83 M
//1.54 M
//1.61 F
//1.75 F

//Saída
//Menor altura = 1.54
//Maior altura = 1.83
//Media das alturas das mulheres = 1.69
//Numero de homens = 2

namespace expdf_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];
            char[] sexo = new char[N];

            // Percorrer o vetor 's' e alocar cada valor de cada string digitada em seu devido vetor (altura/sexo)
            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
            }

            // Percorrer o vetor altura[] e descobrir o maior e menor valor
            double maiorAltura = altura[0]; // apenas para iniciar com algum valor (nesse caso, o primeiro digitado)
            double menorAltura = altura[0]; // apenas para iniciar com algum valor (nesse caso, o primeiro digitado)

            foreach (double x in altura)
            {
                if (x > maiorAltura)
                {
                    maiorAltura = x;
                }   

                if (x < menorAltura)
                {
                    menorAltura = x;
                }
            }
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

            // Descobrir a média de altura das mulheres percorrendo o vetor 'sexo' e o número de homens

            int contMulheres = 0;
            int contHomens = 0;
            double somaAlturaMulheres = 0;
            int k = 0;
            foreach (char x in sexo)
            {
                if (x == 'F')
                {
                    contMulheres++;
                    somaAlturaMulheres += altura[k];
                }
                else
                {
                    contHomens++;
                }
                k++;
            }

            double mediaAlturaMulheres = somaAlturaMulheres / contMulheres;
            Console.WriteLine("Media das alturas das mulheres = " + mediaAlturaMulheres.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + contHomens);
        }
    }
}

// Exercício concluído com sucesso!