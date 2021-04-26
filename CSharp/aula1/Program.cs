using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Informação sobre o nome do vendedor, salário e total de vendas
            Console.WriteLine("Insira o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o seu salário fixo: ");
            int salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o total que fez em vendas durante o mês: ");
            int vendas = int.Parse(Console.ReadLine());

            // Display da informação e calculo do salário final do mês
            Console.WriteLine("");
            double vendas_1 = vendas * 0.15;
            double salario_final = vendas_1 + salario;
            Console.WriteLine($"O nome do vendedor é: {nome}");
            Console.WriteLine($"O salário fixo do vendedor é: {salario}");
            Console.WriteLine($"O salário final do mês após as comissões é: {salario_final}");
            Console.ReadKey();


        }
    }
}
