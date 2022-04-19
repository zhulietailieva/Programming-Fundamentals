using System;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int voucher = int.Parse(Console.ReadLine());
            int tickets = 0; int prizes = 0; 
            while (true)
            {
              string purchase = Console.ReadLine();
               if (purchase == "End") break;
                if (purchase.Length > 8)
                { int ticketsSum = purchase.ToCharArray()[0] + purchase.ToCharArray()[1];
                    if (ticketsSum > voucher) break;
                    tickets++;
                    voucher -= (ticketsSum);
                }
                else
                { int prizesSum = purchase.ToCharArray()[0];
                        if (prizesSum > voucher) break;
                    prizes++;
                    voucher -= prizesSum;
                }
            }
            Console.WriteLine(tickets);
            Console.WriteLine(prizes);
        }//100/100
    }
}
