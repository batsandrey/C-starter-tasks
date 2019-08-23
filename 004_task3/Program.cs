using System;

namespace _004_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            //[0 - 14] [15 - 35] [36 - 50] [50 - 100]. 
            if ((0<=count) && (count <=14))
            {
                Console.WriteLine("from 0 to 14");
            }
            else if ((15 <= count) && (count <= 35))
            {
                Console.WriteLine("from 15 to 35");
            }
            else if ((36 <= count) && (count <= 50))
            {
                Console.WriteLine("from 36 to 50");
            }
            else if ((51 <= count) && (count <= 100))
            {
                Console.WriteLine("from 50 to 100");
            } 
            else Console.WriteLine("We don`t have this digit");

            Console.ReadKey();

        }
    }
}
