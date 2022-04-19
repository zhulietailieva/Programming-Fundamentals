using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veggyMenus = int.Parse(Console.ReadLine());
            double menusPrice = chickenMenus * 10.35 + fishMenus * 12.40 + veggyMenus * 8.15;
            double dessert = 0.2 * menusPrice;
            Console.WriteLine(menusPrice+dessert+2.50);
        }
    }
}
