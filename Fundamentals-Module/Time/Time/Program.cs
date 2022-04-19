using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int adultTickets =int.Parse( Console.ReadLine());
            while (adultTickets < 1 || adultTickets > 400)
            {
                Console.WriteLine("Invalid data, please try again.");
                adultTickets = int.Parse(Console.ReadLine());
            }
            int childrenTickets = int.Parse(Console.ReadLine());
            while (childrenTickets < 5 || adultTickets > 120)
            {
                Console.WriteLine("Invalid data, please try again.");
                childrenTickets = int.Parse(Console.ReadLine());
            }
            double adultTicketPrice = double.Parse(Console.ReadLine());
            while(adultTicketPrice<100.0|| adultTicketPrice > 1600.0)
            {
                Console.WriteLine("Invalid data, please try again.");
                adultTicketPrice = double.Parse(Console.ReadLine());
            }
            double customerPrice = double.Parse(Console.ReadLine());
            while (customerPrice < 10.0 || customerPrice > 50.0)
            {
                Console.WriteLine("Invalid data, please try again.");
                customerPrice = double.Parse(Console.ReadLine());
            }
            int totalTickets = childrenTickets + adultTickets;
            double totalPriceAdultTickets = adultTicketPrice * adultTickets;
            double childrenTicketsPrice = adultTicketPrice - (70 * adultTicketPrice) / 100;
            double totalPriceChildrenTickets = (childrenTicketsPrice*childrenTickets);
            double totalsum = totalPriceAdultTickets + totalPriceChildrenTickets + totalTickets * customerPrice;
            double agencyProfit = 20 * totalsum / 100;
            double finalAnswer = Math.Round(agencyProfit * 100) / 100;
            Console.WriteLine($"The profit of your agency from {companyName} tickets is {string.Format("{0:F2}",finalAnswer)} lv.");

        }
    }
}
