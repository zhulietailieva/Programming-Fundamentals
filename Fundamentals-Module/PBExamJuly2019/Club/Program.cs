using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double goalProfit = double.Parse(Console.ReadLine());          
            double profit = 0;

            while (true)
            {
                double p = 0;
                string cocktail = Console.ReadLine() ;
                if (cocktail == "Party!")
                {
                    Console.WriteLine($"We need {string.Format("{0:F2}", Math.Abs(profit - goalProfit))} leva more.");
                    Console.WriteLine($"Club income - {string.Format("{0:F2}", profit)} leva.");
                    break;
                }
                  int cocktailCount = int.Parse(Console.ReadLine());
                
                double priceCocktail = cocktail.Length;
                p += priceCocktail*cocktailCount;
                if (p % 2 != 0)
                {
                    p -= 0.25 * p;
                }
                profit += p;
                if (profit >= goalProfit)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {string.Format("{0:F2}", profit)} leva.");
                    break;
                }
            }
                
        }
    }
}
