using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double inches = 2.54;
            double santimeters = number * inches;
            Console.WriteLine(santimeters);
        }
    }
}