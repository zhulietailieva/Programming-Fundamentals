using System;

namespace PBExamJuly2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int childTickets = int.Parse(Console.ReadLine());
            double adultPrice = double.Parse(Console.ReadLine());
            double childPrice = adultPrice - (70 * adultPrice / 100);
            double servicePrice = double.Parse(Console.ReadLine());
            int totalTikcets = childTickets + adultTickets;
            double servicePriceTotal = totalTikcets * servicePrice;
            double sum = adultTickets * adultPrice + childTickets * childPrice + servicePriceTotal;
            double profit = 20 * sum / 100;
            Console.WriteLine($"The profit of your agency from {name} tickets is {string.Format("{0:F2}",profit)} lv.");
        }
    }
}
