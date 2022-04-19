using System;

namespace FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double priceDancers= 0;
            if(place== "Bulgaria")
            {
                priceDancers = points * dancers;
            }
            else
            {
                priceDancers= points * dancers;
                priceDancers += 0.5 * priceDancers;
            }

            if (place == "Bulgaria")
            {
               if(season== "summer")
                {
                    priceDancers -= 0.05 * priceDancers;
                }
                else
                {
                    priceDancers -= 0.08 * priceDancers;
                }
            }
            else
            {
                if (season == "summer")
                {
                    priceDancers -= 0.1 * priceDancers;
                }
                else
                {
                    priceDancers -= 0.15 * priceDancers;
                }
            }
            double charity = 0.75 * priceDancers;
            priceDancers -= charity;
            double pricePerDancer = priceDancers / (dancers) * 1.0;

            Console.WriteLine($"Charity - {string.Format("{0:F2}",charity)}");
            Console.WriteLine($"Money per dancer - {string.Format("{0:F2}", pricePerDancer)}");
        }
    }
}
