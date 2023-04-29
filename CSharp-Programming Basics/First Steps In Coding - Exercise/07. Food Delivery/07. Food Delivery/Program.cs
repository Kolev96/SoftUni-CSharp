using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int countchickenMenu = int.Parse(Console.ReadLine());
            int countfishMenu = int.Parse(Console.ReadLine());
            int countvegetarianMenu = int.Parse(Console.ReadLine());

            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegetarianMenu = 8.15;
            double delivery = 2.50;

            double chicken = countchickenMenu * chickenMenu;
            double fish = countfishMenu * fishMenu;
            double vegetarian = countvegetarianMenu * vegetarianMenu;
            double sum = chicken + fish + vegetarian;
            double discountSum = sum * 20 / 100;
            double dessert = discountSum;

            double finalPrice = sum + dessert + delivery;

            Console.WriteLine(finalPrice);



        }
    }
}