using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocartCount = int.Parse(Console.ReadLine());
            int procesorCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double videocart = videocartCount * 250;
            double procesor = videocart * 0.35;
            double discountProcesor = procesor * procesorCount;
            double ram = videocart * 0.10;
            double discountRam = ram * ramCount;
            double sum = videocart + discountProcesor + discountRam;

            if (videocartCount > procesorCount)
            {
                sum = sum - (sum * 0.15);
            }
            if (sum <= budget)
            {
                Console.WriteLine($"You have {Math.Abs(sum - budget):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - sum):f2} leva more!");
            }

        }
    }
}