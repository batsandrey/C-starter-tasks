using System;

namespace _005_task4
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int serviceLenght = Convert.ToInt32(Console.ReadLine());
            int salary = 8000; double prize=0;

            //Если выслуга до 5 лет, премия составляет 10% от заработной платы.
            //Если выслуга от 5 лет(включительно) до 10 лет, премия составляет 15% от заработной платы.
            //Если выслуга от 10 лет(включительно) до 15 лет, премия составляет 25% от заработной платы.
            //Если выслуга от 15 лет(включительно) до 20 лет, премия составляет 35% от заработной платы.
            //Если выслуга от 20 лет(включительно) до 25 лет, премия составляет 45% от заработной платы.
            //Если выслуга от 25 лет(включительно) и более, премия составляет 50% от заработной платы.

            if (serviceLenght < 5)
            {
                prize = salary * 0.1;
            }
            else if ((serviceLenght >= 5)&& (serviceLenght < 10))
            {
                prize = salary * 0.15;
            }
            else if ((serviceLenght >= 10) && (serviceLenght < 15))
            {
                prize = salary * 0.25;
            }
            else if ((serviceLenght >= 15) && (serviceLenght < 20))
            {
                prize = salary * 0.35;
            }
            else if ((serviceLenght >= 20) && (serviceLenght < 25))
            {
                prize = salary * 0.45;
            }
            else if ((serviceLenght >= 25))
            {
                prize = salary * 0.5;
            }
            Console.WriteLine(prize);
        }
    }
}
