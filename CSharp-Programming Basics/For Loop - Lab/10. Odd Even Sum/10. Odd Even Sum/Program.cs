using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countofInputs = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int counter = 1; counter <= countofInputs; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (counter % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}