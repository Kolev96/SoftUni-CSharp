﻿using System;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int finalSum = 0;
            for (int i = 0; i < n; i++)
            {
                char digit = char.Parse(Console.ReadLine());
                finalSum += (int)digit;
            }
            Console.WriteLine($"The sum equals: {finalSum}");
        }
    }
}