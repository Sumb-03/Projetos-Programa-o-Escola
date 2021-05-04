using System;

namespace exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número que pretende para calcular os divisores: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Os divisores são: ");
            for (int num = 1; num <= numero; num++)
            {
                if (numero % num == 0)
                {
                    Console.Write($"{num},");
                }   
            }
        }
    }
}
