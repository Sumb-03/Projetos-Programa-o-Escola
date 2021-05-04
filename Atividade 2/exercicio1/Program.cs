using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receber o número para ser trabalhado
            Console.WriteLine("Introduza o número: ");
            int numero = int.Parse(Console.ReadLine());

            // Output se o número é par ou ímpar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é impar.");
            }

            // Output da divisão inteira por 2
            int divisao = numero / 2;
            Console.WriteLine($"A divisão inteira do numero {numero} é {divisao}.");
            Console.ReadKey();
        }
    }
}
