using System;

namespace ConsoleApp82
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(' ');
            string[] arrTwo = Console.ReadLine().Split(' ');


            foreach (string currelement in arrOne)
            {
                for (int i = 0; i < arrTwo.Length; i++)
                {
                    string secondCurrElement = arrTwo[i];
                    if (currelement == secondCurrElement)
                    {
                        Console.Write($"{currelement} ");
                        break;
                    }
                }
            }
        }
    }
}
