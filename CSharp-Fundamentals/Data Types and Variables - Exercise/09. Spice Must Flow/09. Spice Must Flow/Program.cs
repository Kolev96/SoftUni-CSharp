using System;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CONSUED_BY_WORKERS = 26;
            const int MINIMUM_SPICES_TO_GATHER_FROM_MINE = 100;
            const int DAILY_DEGREES_OF_MINE_YIELD = 10;

            int countOfSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCounted = 0;

            while (countOfSpices >= MINIMUM_SPICES_TO_GATHER_FROM_MINE)
            {
                totalConsumed += countOfSpices - CONSUED_BY_WORKERS;
                countOfSpices -= DAILY_DEGREES_OF_MINE_YIELD;
                daysCounted++;
                if (countOfSpices < MINIMUM_SPICES_TO_GATHER_FROM_MINE)
                {
                    totalConsumed -= CONSUED_BY_WORKERS;
                }
            }

            Console.WriteLine(daysCounted);
            Console.WriteLine(totalConsumed);
        }
    }
}