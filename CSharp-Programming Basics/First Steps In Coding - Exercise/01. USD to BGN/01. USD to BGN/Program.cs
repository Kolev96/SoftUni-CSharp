using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double BGN = double.Parse(Console.ReadLine());
            double USD = 1.79549;
            double SUM = BGN * USD;
            Console.WriteLine(SUM);

        }
    }
}