using System;

namespace exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro positivo.");
            int numero = int.Parse(Console.ReadLine());

            while (numero <= 2)
            {
                if (numero <= 2)
                {
                    Console.WriteLine("Por favor insira um número maior que 2.");
                    Console.WriteLine("Número: ");
                    numero = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("");

            for (int num = 2; num <= numero; num += 2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
