using System;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;
            string biggestKegName = "";

            for (int i = 0; i < nLines; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());

                double volumeOfTheCurrentKeg = Math.PI * Math.Pow(radius, 2) * hight;

                //:  π* r^2 * h.

                if (volumeOfTheCurrentKeg > biggestKeg)
                {
                    biggestKeg = volumeOfTheCurrentKeg;
                    biggestKegName = model;
                }
            }

            Console.WriteLine(biggestKegName);
        }
    }
}
