using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int countofPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int countofDays = int.Parse(Console.ReadLine());
            int totalHours = countofPages / pagesPerHour;
            int hoursPerDay = totalHours / countofDays;
            Console.WriteLine(hoursPerDay);

        }
    }
}