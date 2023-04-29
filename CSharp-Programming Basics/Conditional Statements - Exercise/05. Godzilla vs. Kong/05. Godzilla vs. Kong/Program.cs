using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double clothesPriceForStatist = double.Parse(Console.ReadLine());

            double clothesPrice = clothesPriceForStatist * statist;
            double decor = budget * 0.10;

            if (statist > 150)
            {
                clothesPrice = clothesPrice - (clothesPrice * 0.1);
            }
            double filmCost = decor + clothesPrice;

            if (filmCost <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - filmCost:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - filmCost):F2} leva more.");
            }
        }
    }
}