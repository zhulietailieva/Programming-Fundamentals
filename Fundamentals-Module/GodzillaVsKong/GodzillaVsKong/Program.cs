using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());
            double decor = 0.1 * budget;
            double sumClothing = extras * clothing;
            if (extras > 150) sumClothing -= 0.1 * sumClothing;
            double sumMovie = decor + sumClothing;
            if (sumMovie > budget)
            { double moneyLeft = sumMovie - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs "+string.Format("{0:F2}",moneyLeft)+" leva more.");
            }
            else
            {
                double moneyLeft = budget - sumMovie;
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with "+string.Format("{0:F2}",moneyLeft)+" leva left.");

            }
        }
    }
}
