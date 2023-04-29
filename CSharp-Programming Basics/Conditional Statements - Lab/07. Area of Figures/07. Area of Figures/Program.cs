using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double parameters = double.Parse(Console.ReadLine());
                double square = parameters * parameters;
                Console.WriteLine($"{square:f3}");
            }
            else if (figure == "rectangle")
            {
                double parameters1 = double.Parse(Console.ReadLine());
                double parameters2 = double.Parse(Console.ReadLine());
                double rectangle = parameters1 * parameters2;
                Console.WriteLine($"{rectangle:f3}");
            }
            else if (figure == "circle")
            {
                double circleSize = double.Parse(Console.ReadLine());
                double circle = circleSize * circleSize * Math.PI;
                Console.WriteLine($"{circle:f3}");
            }
            else if (figure == "triangle")
            {
                double triangleSize1 = double.Parse(Console.ReadLine());
                double triangleSize2 = double.Parse(Console.ReadLine());
                double triangle = triangleSize1 * triangleSize2 / 2;
                Console.WriteLine($"{triangle:f3}");
            }


        }
    }
}