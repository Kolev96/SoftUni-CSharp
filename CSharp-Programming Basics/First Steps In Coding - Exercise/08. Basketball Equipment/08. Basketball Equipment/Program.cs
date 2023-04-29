using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int anualTax = int.Parse(Console.ReadLine());

            double basketballShoes = anualTax - (0.4 * anualTax);
            double basketballClothes = basketballShoes - (0.2 * basketballShoes);
            double basketballBall = basketballClothes / 4;
            double basketballAccessories = basketballBall / 5;

            double sum = anualTax + basketballShoes + basketballClothes + basketballBall + basketballAccessories;

            Console.WriteLine(sum);
        }
    }
}
