using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());


            dogFood *= 2.50;
            catFood *= 4;

            Console.WriteLine($"{dogFood + catFood} lv.");



        }
    }
}