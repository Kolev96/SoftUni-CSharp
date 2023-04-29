using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination;
            string placeSummer = "Camp";
            string placeWinter = "Hotel";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{placeSummer} - {budget * 0.30:f2}");
                }

                else if (season == "winter")
                {
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{placeWinter} - {budget * 0.70:f2}");
                }
            }

            if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{placeSummer} - {budget * 0.40:f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{placeWinter} - {budget * 0.80:f2}");
                }
            }

            if (budget > 1000)
            {
                destination = "Europe";
                budget *= 0.90;

                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{placeWinter} - {budget:f2}");
            }
        }
    }
}
