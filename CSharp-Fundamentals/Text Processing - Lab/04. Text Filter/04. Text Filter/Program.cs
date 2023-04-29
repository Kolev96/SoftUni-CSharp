using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                string replacedWithAsteriksks = new string('*', bannedWord.Length);

                text = text.Replace(bannedWord, replacedWithAsteriksks);
            }

            Console.WriteLine(text);

        }
    }
}
