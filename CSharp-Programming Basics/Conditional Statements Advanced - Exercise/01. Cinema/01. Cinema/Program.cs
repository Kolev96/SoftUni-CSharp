using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rol = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double income = rol * col;

            if (type == "Premiere")
            {
                income *= 12.00;
            }
            else if (type == "Normal")
            {
                income *= 7.50;
            }
            else
            {
                income *= 5.00;
            }
            Console.WriteLine($"{income:f2} leva");

        }
    }
}