using System;

namespace exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receber o número para calcular os divisores
            Console.WriteLine("Insira o número que pretende para calcular os divisores: ");
            int numero = int.Parse(Console.ReadLine());

            // Cálculo dos divisores
            Console.WriteLine("");
            Console.Write("Os divisores são: ");
            for (int num = 1; num <= numero; num++)
            {
                if (numero % num == 0)
                {
                    Console.Write($"{num},");
                }   
            }
            Console.ReadKey();
        }
    }
}
