using System;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int linhas = 0;

            Console.WriteLine("Digite o número de linhas:");
            linhas = Convert.ToInt32(Console.ReadLine());

            int tamanho = (linhas - 1) / 2;
            int espaço = (linhas - 1) / 2;

            for (int i = 0; i < tamanho; i++) 
            {
                for (int k =0; k <espaço; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j<a; j++)
                {
                    Console.Write("x");
                }
                a +=2;
                espaço--;
                Console.Write("\n");
            }
            for (int i = linhas; i > 0; i--) 
            {
                for (int k = 0; k < espaço; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < a; j++)
                {
                    Console.Write("x");
                }
                a -= 2;
                espaço++;
                Console.Write("\n");

            }
        }
    }
}
