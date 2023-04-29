using System;

namespace _01._Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number >= 5.50)
            {
                Console.WriteLine($"Excellent!");
            }
        }
    }
}