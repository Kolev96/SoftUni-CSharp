using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int lengthofWord = word.Length;
            for (int index = 0; index <= lengthofWord - 1; index++)
            {
                Console.WriteLine($"{word[index]}");
            }
        }
    }
}