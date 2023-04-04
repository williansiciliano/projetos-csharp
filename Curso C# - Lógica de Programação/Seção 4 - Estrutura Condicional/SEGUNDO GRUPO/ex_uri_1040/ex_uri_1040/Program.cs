using System;
using System.Globalization;

namespace ex_uri_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            //enunciado em: https://www.beecrowd.com.br/judge/pt/problems/view/1040

            float N1, N2, N3, N4, media1, notaExame, media2;

            string[] vet = Console.ReadLine().Split(' ');
            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            media1 = (float) Math.Round(((N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10), 1);
            // SOLUÇÃO DO PROFESSOR:
            // O problema 1040 tem uma falha de arredondamento especifica
            // para a linguagem C#. Quando a media da 4.85, nos temos que
            // ajusta-la manualmente para 4.8, o que eh uma "gambiarra"
            // horrivel, infelizmente. Isso nao aconteceu nas outras 
            // linguagens que testamos, tais como Java, C e C++
            //if (media == 4.85f)
            //{
            //    media = 4.8f;
            //}

            // MINHA SOLUÇÃO: USAR MATH.ROUND (PORÉM CONVERTENDO PARA FLOAT POR CASTING)

            Console.WriteLine("Media: " + media1.ToString("F1", CultureInfo.InvariantCulture));

            if ( media1 >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            } 
            else if ( media1 < 5.0) 
            {
                Console.WriteLine("Aluno reprovado.");
            } 
            else 
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));

                media2 = (media1 + notaExame) / 2;

                if ( media2 >= 5.0) 
                {
                    Console.WriteLine("Aluno aprovado.");
                } 
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media2.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
