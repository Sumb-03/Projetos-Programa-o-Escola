using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receber os números e operador
            Console.WriteLine("Insira o primeiro número: ");
            int numero_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o operador: ");
            string operador = Console.ReadLine();
            Console.WriteLine("Insira o segundo número: ");
            int numero_2 = int.Parse(Console.ReadLine());

            // Cálculos
            switch(operador)
            {
                case "+":
                        int adição = numero_1 + numero_2;
                        Console.WriteLine($"Resultado: {adição}");
                break;
                case "-":
                        int subtração = numero_1 - numero_2;
                        Console.WriteLine($"Resultado: {subtração}");
                break;
                case "*":
                        int multiplicação = numero_1 * numero_2;
                        Console.WriteLine($"Resultado: {multiplicação}");
                break;
                case "/":
                        int divisão = numero_1 / numero_2;
                        Console.WriteLine($"Resultado: {divisão}");
                break;
            }
        }
    }
}
