using System;

namespace exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receber as noites para ficar no hotel
            Console.WriteLine("Bom Dia! Por favor insira quantas noites deseja ficar no hotel: ");
            int noite = int.Parse(Console.ReadLine());
            int total = 0;

            // Se o número de noites for 0 voltar a por
            while (noite == 0)
            {
                if (noite == 0)
                {
                    Console.WriteLine("O número introduzido não pode ser 0. Tente outra vez!");
                    noite = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("");

            // Cálculos para pagar por noite consoante os dias que se vai passar no hotel
            for (int i = 1; i <= noite; i++)
            {
                int preco = 50;
                int preco_n = preco / i;
                Console.WriteLine($"A {i}ª noite vai custar {preco_n} euros.");
    	        total += preco_n;

            }
            // Total que vai pagar no fim
            Console.WriteLine($"O valor total a pagar é {total} euros.");
            Console.ReadKey();
    
        }
    }
}
