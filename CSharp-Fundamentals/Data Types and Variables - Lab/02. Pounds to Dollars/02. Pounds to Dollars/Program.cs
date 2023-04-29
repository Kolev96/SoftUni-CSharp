using System;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            double dollars = 1.31;

            double sum = pounds * dollars;

            Console.WriteLine($"{sum:f3}");
        }
    }
}