using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonNeeded = int.Parse(Console.ReadLine());
            int paintNeeded = int.Parse(Console.ReadLine());
            int liquidNeeded = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylonNeeded + 2) * 1.50;
            double paintPrice = (paintNeeded + 1.1) * 14.50;
            double liguidPrice = liquidNeeded * 5.00;
            double priceBag = 0.40;

            double sum = nylonPrice + paintPrice + liguidPrice + priceBag;
            double sumCarpenter = sum * 0.3 * hours;

            Console.WriteLine(sum + sumCarpenter);

        }
    }
}