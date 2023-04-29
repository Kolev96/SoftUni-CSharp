using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * heigth;
            double volumeInLiters = volume / 1000;
            double closedVolume = percent * 0.01;
            double neededLiters = volumeInLiters * (1 - closedVolume);

            Console.WriteLine(neededLiters);
        }
    }
}