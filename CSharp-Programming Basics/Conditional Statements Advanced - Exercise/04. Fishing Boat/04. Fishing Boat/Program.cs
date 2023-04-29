using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishers = int.Parse(Console.ReadLine());
            double money = 0;

            switch (season)
            {
                case "Spring":
                    money = 3000;
                    break;
                case "Summer":
                    money = 4200;
                    break;
                case "Autumn":
                    money = 4200;
                    break;
                case "Winter":
                    money = 2600;
                    break;
                default:
                    break;
            }

            if (countFishers <= 6)
            {
                money = money - money * 0.10;
            }
            else if (countFishers <= 11)
            {
                money = money - money * 0.15;
            }
            else
            {
                money = money - money * 0.25;
            }

            if (countFishers % 2 == 0 && season != "Autumn")
            {
                money = money - money * 0.05;
            }
            if (budget >= money)
            {
                Console.WriteLine($"Yes! You have {budget - money:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {money - budget:f2} leva.");
            }
        }
    }
}
