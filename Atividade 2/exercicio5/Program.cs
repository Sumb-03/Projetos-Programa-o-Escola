using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receber o número para ser trabalhado
            Console.WriteLine("Introduza o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            //Cálculos
            if (numero1 % 2 == 0)
            {
                if (numero2 % 2 == 0)
                {
                    int soma = numero1 + numero2;
                    Console.WriteLine($"A soma dos números é {soma}.");
                    
                }
            }
            else if (numero1 % 2 != 0)
            {
                if (numero2 % 2 != 0)
                {
                    int produto = numero1 * numero2;
                    Console.WriteLine($"O produto dos números é {produto}.");
                    
                }
            }
            
            if (numero1 % 2 != 0)
            {
                if (numero2 % 2 == 0)
                {
                    Console.WriteLine($"O número {numero1} é impar.");
                }
            }
            else if (numero1 % 2 == 0)
            {
                if (numero2 % 2 != 0)
                {
                    Console.WriteLine($"O número {numero2} é impar.");
                }
            }
        }
    }
}
