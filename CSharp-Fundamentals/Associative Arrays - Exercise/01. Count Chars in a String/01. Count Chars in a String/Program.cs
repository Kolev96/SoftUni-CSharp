using System;
using System.Collections.Generic;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray(); // "text" => ['t', 'e','x','t']
            Dictionary<char, int> letters = new Dictionary<char, int>();//{char: int} => {chat 't': int2}

            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter)) //letters.Contains('t')
                    {
                        letters[letter] = 0;
                    }
                    letters[letter]++;
                }
            }

            foreach (var kvpLetter in letters)
            {
                Console.WriteLine($"{kvpLetter.Key} -> {kvpLetter.Value}");
            }
        }
    }
}