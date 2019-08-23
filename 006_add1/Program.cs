using System;

namespace _006_add1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            
        }
    }
}
