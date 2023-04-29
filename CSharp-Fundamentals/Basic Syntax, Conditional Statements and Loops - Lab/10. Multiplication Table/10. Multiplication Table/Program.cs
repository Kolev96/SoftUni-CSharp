using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = 1;

            while (times <= 10)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
                times++;
            }

        }
    }
}