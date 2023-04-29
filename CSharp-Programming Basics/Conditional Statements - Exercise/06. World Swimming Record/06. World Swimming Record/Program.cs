using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

            double swimedDistance = distanceInMeters * timeInSecondsForOneMeter;
            double slowedTime = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalTime = swimedDistance + slowedTime;

            if (recordInSeconds > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double neededTime = totalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {neededTime:f2} seconds slower.");

            }

        }
    }
}