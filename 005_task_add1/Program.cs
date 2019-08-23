using System;

namespace _005_task_add1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte operand1 = 0, operand2 = 0;
            int result;

            operand1 = 0xFF;                         // [1111 1111 Bin] = [FF Hex] = [255 Dec]            
            operand2 = 0x00;                         // [0000 0001 Bin] = [01 Hex] = [01 Dec]
            result = operand1 ^ operand2;

            Console.WriteLine(result);
        }
    }
}
