using System;

namespace _003_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            x += y - x++ * z;
            Console.WriteLine("x= " + x);
            z = --x - y * 5;
            Console.WriteLine("z= " + z);
            y /= x + 5 % z;
            Console.WriteLine("y= " + y);
            z = x++ + y * 5;
            Console.WriteLine("z= " + z);
            x = y - x++ * z;
            Console.WriteLine("x= " + x);
        }
    }
}
