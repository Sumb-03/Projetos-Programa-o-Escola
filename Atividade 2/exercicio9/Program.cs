using System;

namespace exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 100; num <= 1000; num++)
            {
                if (num % 5 == 0)
                {
                    if (num % 3 != 0)
                    {
                        Console.WriteLine(num); 
                    }
                }   
            }
        }
    }
}
