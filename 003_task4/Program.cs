using System;

namespace _003_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double π = 3.14;
            int R = 2, h = 15;
            double V = π * Math.Pow(R,2) * h;
            Console.WriteLine("V " + V);

            double S = 2*π*R*(R + h);
            Console.WriteLine("S " + S);

            //int uberflu?, _Identifier,  \u006fIdentifier, &myVar, myVariab1le;
        }
    }
}
