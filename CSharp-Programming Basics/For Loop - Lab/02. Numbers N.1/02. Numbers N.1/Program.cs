using System;

namespace Numbers_N_To_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int counter = number; counter >= 1; --counter)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
