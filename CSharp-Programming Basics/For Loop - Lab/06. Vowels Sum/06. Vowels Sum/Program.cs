using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int lengthofWord = word.Length;
            int sum = 0;
            for (int index = 0; index <= lengthofWord - 1; index++)
            {
                char currentLetter = word[index];
                switch (currentLetter)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;

                }
            }
            Console.WriteLine(sum);
        }
    }
}