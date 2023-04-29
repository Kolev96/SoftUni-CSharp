using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int deposedSum = int.Parse(Console.ReadLine());
            int deposedTime = int.Parse(Console.ReadLine());
            double percentPerYear = double.Parse(Console.ReadLine());

            double sum = deposedSum + deposedTime * ((deposedSum * (percentPerYear / 100)) / 12);

            Console.WriteLine(sum);

        }
    }
}