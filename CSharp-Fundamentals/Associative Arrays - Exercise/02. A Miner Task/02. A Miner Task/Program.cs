using System;
using System.Collections.Generic;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, int>();
            string resources = Console.ReadLine();

            while (resources != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(resources))
                {
                    items.Add(resources, 0);
                }
                items[resources] += quantity;
                resources = Console.ReadLine();
            }

            foreach (var curResources in items)
            {
                Console.WriteLine($"{curResources.Key} -> {curResources.Value}");
            }
        }


    }
}