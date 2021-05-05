using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduzir os 3 números inteiros
            Console.WriteLine("Insira o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            // Elevar os números a 2
            double a1 = Math.Pow(a, 2);
            double b1 = Math.Pow(b, 2);
            double c1 = Math.Pow(c, 2);

            // Determinar se estes 3 números podem ser os comprimentos dos lados de um triângulo retângulo

            if (a > b)
            {
                if (a > c)
                {
                    if (a1 == b1 + c1)
                    {
                        Console.WriteLine("Os números podem ser lados de um triângulo retângulo.");
                    }
                    else
                    {
                        Console.WriteLine("Os números não podem ser lados de um triângulo retângulo.");
                    }
                }
                else if (a < c)
                {
                    if (c1 == a1 + b1)
                    {
                        Console.WriteLine("Os números podem ser lados de um triângulo retângulo.");
                    }
                    else
                    {
                        Console.WriteLine("Os números não podem ser lados de um triângulo retângulo.");
                    }
                }   
            }
            else if (b > a)
            {
                if (b > c)
                {
                    if (b1 == a1 + c1)
                    {
                        Console.WriteLine("Os números podem ser lados de um triângulo retângulo.");
                    }
                    else
                    {
                        Console.WriteLine("Os números não podem ser lados de um triângulo retângulo.");
                    }
                }
                else if (b < c)
                {
                    if (c1 == a1 + b1)
                    {
                        Console.WriteLine("Os números podem ser lados de um triângulo retângulo.");
                    }
                    else
                    {
                        Console.WriteLine("Os números não podem ser lados de um triângulo retângulo.");
                    }
                }   
            }
            else if (c > b)
            {
                if (c > a)
                {
                    if (c1 == a1 + b1)
                    {
                        Console.WriteLine("Os números podem ser lados de um triângulo retângulo.");
                    }
                    else
                    {
                        Console.WriteLine("Os números não podem ser lados de um triângulo retângulo.");
                    }
                }
                else if (c < a)
                {
                    if (a1 == b1 + c1)
                    {
                        Console.WriteLine("Os números podem ser lados de um triângulo retângulo.");
                    }
                    else
                    {
                        Console.WriteLine("Os números não podem ser lados de um triângulo retângulo.");
                    }
                }   
            }

            //Console.WriteLine("");

            // Determinar a soma dos seus quadrados
            double soma_quadrados = a1 + b1 + c1;
            Console.WriteLine($"A soma dos quadrados é {soma_quadrados}.");

            // Determinar o quadrado da soma
            int soma = a + b + c;
            double quadrado_soma = Math.Pow(soma, 2);
            Console.WriteLine($"O quadrado da sua soma é {quadrado_soma}.");

            // Determinar a média aritmética
            float media = soma / 3;
            Console.WriteLine($"A média dos 3 números é {media}.");

            Console.WriteLine("");
            Console.ReadKey();  
        }
    }
}
