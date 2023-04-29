using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int countPuzzels = int.Parse(Console.ReadLine());
            int countDolls = int.Parse(Console.ReadLine());
            int countTeddyBears = int.Parse(Console.ReadLine());
            int countMinions = int.Parse(Console.ReadLine());
            int countTrucks = int.Parse(Console.ReadLine());

            double puzzelPrice = countPuzzels * 2.60;
            double dollPrice = countDolls * 3;
            double teddybearPrice = countTeddyBears * 4.10;
            double minionPrice = countMinions * 8.20;
            double truckPrice = countTrucks * 2;

            double toysSum = puzzelPrice + dollPrice + teddybearPrice + minionPrice + truckPrice;
            int countofToys = countPuzzels + countDolls + countTeddyBears + countMinions + countTrucks;

            if (countofToys >= 50)
            {
                double discount = toysSum * 0.25;
                toysSum -= discount;
            }

            double rentPrice = toysSum * 0.10;
            toysSum -= rentPrice;

            if (toysSum >= priceExcursion)
            {
                double moneyLeft = toysSum - priceExcursion;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left. ");
            }
            else
            {
                double neededMoney = priceExcursion - toysSum;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed. ");
            }


        }
    }
}