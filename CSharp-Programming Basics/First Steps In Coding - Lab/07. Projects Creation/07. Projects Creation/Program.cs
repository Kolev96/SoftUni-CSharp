using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameofarchitect = Console.ReadLine();
            int countofprojects = int.Parse(Console.ReadLine());
            int oneproject = 3;
            int sum = countofprojects * oneproject;

            Console.WriteLine($"The architect {nameofarchitect} will need {sum} " +
                $"hours to complete {countofprojects} project/s.");


        }
    }
}