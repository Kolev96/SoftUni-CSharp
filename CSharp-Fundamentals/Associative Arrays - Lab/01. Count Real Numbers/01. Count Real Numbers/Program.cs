using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> occurencesByNumber = new SortedDictionary<int, int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (occurencesByNumber.ContainsKey(number))
                {
                    int currentOccurences = occurencesByNumber[number];

                    currentOccurences += 1;

                    occurencesByNumber[number] = currentOccurences;
                }
                else
                {
                    occurencesByNumber.Add(number, 1);
                }
            }

            foreach (var occurenceByNumber in occurencesByNumber)
            {
                Console.WriteLine($"{occurenceByNumber.Key} -> {occurenceByNumber.Value}");
            }
        }
    }
}