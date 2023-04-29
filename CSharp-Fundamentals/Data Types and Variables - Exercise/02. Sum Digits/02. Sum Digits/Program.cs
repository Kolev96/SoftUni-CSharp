using System;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            //int.Parse(Console.ReadLine) = > "12345" = > 12345 % 10 => 5
            //1234 / 10 => 1234

            // 1. First try to solve the problem

            //int numInput = int.Parse(Console.ReadLine());
            //int finalResult = 0;

            //while (numInput != 0)
            //{
            //    int lastDigit = numInput % 10;
            //    finalResult += lastDigit;
            //    numInput /= 10;
            //}

            //Console.WriteLine(finalResult);

            //Second Try to solve the problem

            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            int finalSum = 0;

            for (int value = 0; value < charArray.Length; value++)
            {
                finalSum += int.Parse(charArray[value].ToString());
            }

            Console.WriteLine(finalSum);

        }
    }
}
