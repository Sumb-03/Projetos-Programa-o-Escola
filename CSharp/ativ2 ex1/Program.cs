using System;

namespace ativ2_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é impar.");
            }

            int divisao = numero / 2;
            Console.WriteLine($"A divisão inteira do numero {numero} é {divisao}.");
            Console.ReadKey();

        }
    }
}
