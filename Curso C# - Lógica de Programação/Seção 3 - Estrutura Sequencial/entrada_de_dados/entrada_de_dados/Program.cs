using System;
using System.Globalization;

namespace entrada_de_dados{
    class Program{
        static void Main(string[] args) {

            /* 
            Vídeo 17 (Entrada de dados em C#(PARTE 1)) da Seção 3 do Curso de C#:
            Exercício: Fazer aparecer o seguinte no Console:
            Bom dia!
            Vermelho
            Verde
            Azul
            Amarelo Laranja Cinza
            */

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            //Agora vamos ler 3 valores separados por espaços e armazenar cada um deles em uma variável(usar o comando SPLIT em um VETOR):
            
            string[] vet = Console.ReadLine().Split(' '); // Separa a string nos espaços e aloca cada parte em uma posição do vetor.
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.Write(a + " ");
            Console.Write(b + " ");
            Console.Write(c);
        }
    }
}
