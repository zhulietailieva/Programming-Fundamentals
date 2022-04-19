using System;

namespace Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int numstays = int.Parse(Console.ReadLine());
            int transportCards = int.Parse(Console.ReadLine());
            int numTickets = int.Parse(Console.ReadLine());
            double totalsum = 0;
            double sumPerPerson = numstays * 20 + transportCards * 1.6 + numTickets * 6;
            
            totalsum = sumPerPerson * numPeople;
            totalsum += 0.25 * totalsum;
            Console.WriteLine(string.Format("{0:F2}",totalsum));
        }
    }
}
