using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPencil = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());



            double packetOfPencil = 5.80 * countPencil;
            double packetMarkers = 7.20 * countMarkers;
            double cleanerPerLiter = 1.20 * liters;

            double sum = packetOfPencil + packetMarkers + cleanerPerLiter;

            Console.WriteLine(sum - ((discountPercent / 100) * sum));

        }
    }
}