using System;

namespace ToyShop2
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int tBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double totalToys = puzzels + dolls + tBears + minions + trucks;
            double toysPrice = puzzels * 2.6 + dolls * 3 + tBears * 4.1 + minions * 8.2 + trucks * 2;
            if (totalToys >= 50)
            {
                toysPrice = 0.75 * toysPrice;
            }
            double rent = 0.1 * toysPrice;
            double res = toysPrice - rent;
            if (res < holidayPrice)
            {
                Console.WriteLine($"Not enough money! {string.Format("{0:F2}",holidayPrice-res)} lv needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {string.Format("{0:F2}", res - holidayPrice)} lv left.");
            }
        }
    }
}
