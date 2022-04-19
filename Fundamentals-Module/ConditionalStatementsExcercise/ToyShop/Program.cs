using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());//*2.6
            int dolls = int.Parse(Console.ReadLine());//*3
            int teddyBears = int.Parse(Console.ReadLine());//*4.1
            int minions = int.Parse(Console.ReadLine());//*8.2
            int trucks = int.Parse(Console.ReadLine());//*2

            double sum = puzzels * 2.6 + dolls * 3 + teddyBears * 4.1 + minions * 8.2 + trucks * 2;
            if (puzzels + dolls + teddyBears + minions + trucks >= 50) sum -= 0.25 * sum;
            double rent = 0.1 * sum;
            sum -= rent;
            if (sum >= holidayPrice)
            {
                Console.WriteLine($"Yes! {string.Format("{0:F2}",sum-holidayPrice)} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {string.Format("{0:F2}",holidayPrice- sum  )} lv needed.");
            }
        }
    }
}
