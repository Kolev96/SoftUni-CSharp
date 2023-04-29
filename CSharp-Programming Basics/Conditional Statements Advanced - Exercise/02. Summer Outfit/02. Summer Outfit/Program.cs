using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (temperature >= 0 && temperature <= 18)
            {
                switch (time)
                {
                    case "Morning":
                        Console.WriteLine($"It's {temperature} degrees, get your Sweatshirt and Sneakers.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                        break;
                    case "Avening":
                        Console.WriteLine($"It's {temperature} degrees, get your Sweatshirt and Moccasins.");
                        break;
                }
            }
            if (temperature > 18 && temperature <= 24)
            {
                switch (time)
                {
                    case "Morning":
                        Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
                        break;
                    case "Evening":
                        Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
            if (temperature >= 25)
            {
                switch (time)
                {
                    case "Morning":
                        Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {temperature} degrees, get your Swim Suit and Barefoot.");
                        break;
                    case "Evening":
                        Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
        }
    }
}