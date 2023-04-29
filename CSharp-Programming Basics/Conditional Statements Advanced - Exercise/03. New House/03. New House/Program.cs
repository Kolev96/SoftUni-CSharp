using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int roses = 5 * countFlowers;
            double dahlias = 3.80 * countFlowers;
            double tulips = 2.80 * countFlowers;
            int narcissus = 3 * countFlowers;
            double gladiolus = 2.50 * countFlowers;
            double sum = 0;

            if (flowers == "Roses")
            {
                sum = roses;

                if (countFlowers > 80)
                {
                    sum = roses * 0.90;
                }
            }

            else if (flowers == "Dahlias")
            {
                sum = dahlias;

                if (countFlowers > 90)
                {
                    sum = dahlias * 0.85;
                }
            }

            else if (flowers == "Tulips")
            {
                sum = tulips;

                if (countFlowers > 80)
                {
                    sum = tulips * 0.85;
                }

            }

            else if (flowers == "Narcissus")
            {
                sum = narcissus;

                if (countFlowers < 120)
                {
                    sum = narcissus * 1.15;
                }
            }

            else if (flowers == "Gladiolus")
            {
                sum = gladiolus;

                if (countFlowers < 80)
                {
                    sum = gladiolus * 1.20;
                }
            }

            if (budget >= sum)
            {
                double moneyLeft = budget - sum;
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {flowers} and {moneyLeft:f2} leva left.");
            }

            else
            {
                double moneyNeeded = sum - budget;
                Console.WriteLine($"Not enough money, you need {Math.Abs(moneyNeeded):f2} leva more.");
            }
        }
    }
}