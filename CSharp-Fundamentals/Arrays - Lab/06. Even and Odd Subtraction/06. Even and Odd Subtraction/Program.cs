using System;
using System.Linq;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evensum = 0;
            int odsum = 0;

            foreach (var number in numbers)
            {

                if (number % 2 == 0)
                {
                    evensum += number;
                }
                else
                {
                    odsum += number;
                }
            }

            Console.WriteLine(evensum - odsum);
        }
    }
}