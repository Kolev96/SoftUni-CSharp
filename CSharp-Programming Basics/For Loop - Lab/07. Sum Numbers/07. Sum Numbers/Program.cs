using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countofInputs = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int counter = 0; counter < countofInputs; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}