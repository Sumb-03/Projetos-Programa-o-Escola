using System;

namespace exercicio_7b
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero = random.Next(1, 11);
            Console.WriteLine("Foi gerado um número aleatório entre 1 a 10. Tente adivinhar qual é.");
            Console.WriteLine("Número: ");
            int tentativa = int.Parse(Console.ReadLine());
            int tentativas = 10;

            if (tentativa == numero)
            {
                Console.WriteLine("Parabéns acertou!");
            }
            else
            {
                while (tentativa != numero)
                {
                    tentativas--;
                    if (tentativa > numero)
                    {
                        Console.WriteLine($"Errou,tem {tentativas} tentativas. Tente outra vez! Ajuda, o número que inseriu é maior que o que pensa.");
                        Console.WriteLine("Número: ");
                        tentativa = int.Parse(Console.ReadLine());
                    }
                    else if (tentativa < numero)
                    {
                        Console.WriteLine($"Errou,tem {tentativas} tentativas. Tente outra vez! Ajuda, o número que inseriu é menor que o que pensa.");
                        Console.WriteLine("Número: ");
                        tentativa = int.Parse(Console.ReadLine());
                    }
                    
                    if (tentativa == numero)
                    {
                        Console.WriteLine("Parabéns acertou!");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
