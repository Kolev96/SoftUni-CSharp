using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string fullString = Console.ReadLine();

            while (fullString.Contains(substringToRemove))
            {
                int startIndex = fullString.IndexOf(substringToRemove);

                fullString = fullString.Remove(startIndex, substringToRemove.Length);
            }

            Console.WriteLine(fullString);


        }
    }
}