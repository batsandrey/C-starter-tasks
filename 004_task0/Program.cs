using System;

namespace _004_task0
{
    class Program
    {
        static void Main(string[] args)
        {

            String str = Console.ReadLine();

            switch (str)
            {
                case "good":
                    Console.WriteLine("хорошая");
                    break;
                case "bad":
                    Console.WriteLine("плохая");
                    break;
                case "sunny":
                    Console.WriteLine("солнечная");
                    break;
                case "rainy":
                    Console.WriteLine("дождливая");
                    break;
                default:
                    Console.WriteLine("Doesn`t have this word");
                    break;
            }
            
        }
    }
}
