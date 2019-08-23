using System;

namespace _006_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = 0;

            for (double i = x + 1; i < y; i++)
            {
                res += i;
                if (!(i % 2 == 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(res);
        }
    }
}