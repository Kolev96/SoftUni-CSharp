using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int second1 = int.Parse(Console.ReadLine());
            int second2 = int.Parse(Console.ReadLine());
            int second3 = int.Parse(Console.ReadLine());

            int totalTime = second1 + second2 + second3;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");

            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }


        }
    }
}
