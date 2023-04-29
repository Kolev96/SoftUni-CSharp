using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double km2 = double.Parse(Console.ReadLine());

            double oneKm2 = 7.61;
            double sum = km2 * oneKm2;
            double discount = 0.18 * sum;
            double finalPrice = sum - discount;

            Console.WriteLine($"The final price is: {finalPrice:f2} lv. ");
            Console.WriteLine($"The discount is: {discount:f2} lv. ");

        }
    }
}