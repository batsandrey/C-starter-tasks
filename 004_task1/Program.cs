using System;

namespace _004_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1=12, operand2=2;
            String sign;
            sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(operand1+operand2);
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "/":
                    if(operand2 == 0)
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                    }
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
            }
        }
    }
}
