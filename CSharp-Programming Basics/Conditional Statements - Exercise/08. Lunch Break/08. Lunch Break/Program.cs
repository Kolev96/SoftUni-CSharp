using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double epizod = double.Parse(Console.ReadLine());
            double brake = double.Parse(Console.ReadLine());

            double lunchTime = brake * 0.125;
            double restTime = brake * 0.25;
            double timeLeft = epizod + lunchTime + restTime;

            if (timeLeft <= brake)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(brake - timeLeft)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeLeft - brake)} more minutes.");
            }

        }
    }
}