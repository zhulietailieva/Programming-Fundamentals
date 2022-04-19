using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());
            double decor = 0.1 * budget;
            double sumClothing=extras*clothingPrice;
            if (extras > 150) sumClothing -= 0.1 * sumClothing;
            double sumTotal = decor + sumClothing;
            if (sumTotal <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {string.Format("{0:F2}",budget-sumTotal)} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {string.Format("{0:F2}", sumTotal - budget)} leva more.");
            }
        }
    }
}
