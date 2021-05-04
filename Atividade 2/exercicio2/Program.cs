using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receber o preço do artigo
            Console.WriteLine("Insira o preço do artigo: ");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine();

            // Cálculo do desconto 
            if (preco > 10000)
            {
                double total = preco * 0.6;
                Console.WriteLine($"O preço do artigo em saldo é {total}.");
            }
            else if (preco <= 10000)
            {
                double total = preco * 0.8;
                Console.WriteLine($"O preço do artigo em saldo é {total}.");
            }
            else if (preco <= 5000)
            {
                double total = preco * 0.9;
                Console.WriteLine($"O preço do artigo em saldo é {total}.");
            }
            else if (preco <= 2500)
            {
                double total = preco * 0.95;
                Console.WriteLine($"O preço do artigo em saldo é {total}.");
            }

            Console.ReadKey();

        }
    }
}
