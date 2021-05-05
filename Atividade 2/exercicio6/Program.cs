using System;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            int soma = 0;
            while (numero < 201)
            {
                
                if (numero % 2 == 0)
                {
                    soma += numero;
                    
                }
                numero++;
            }
            Console.WriteLine($"A soma dos números pares entre 2 e 200 é: {soma}");

            Console.ReadKey();
        }
    }
}
