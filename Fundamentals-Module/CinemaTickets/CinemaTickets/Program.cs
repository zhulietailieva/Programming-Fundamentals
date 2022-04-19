using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
               int studentTickets = 0; ;
               int standardTickets = 0;
               int kidTickets = 0;
               double ticketsTotal = 0;
               
               while (true)
               {
                               
                string movieName = Console.ReadLine();  
                double seatsTaken = 0; 
                   if (movieName == "Finish") break;
                   int freeSeats = int.Parse(Console.ReadLine());
                double freeSeatsConst = freeSeats;
                   string ticketType = Console.ReadLine();
                 ticketsTotal++; 
               
                   while (freeSeats > 1 && ticketType != "End")
                   {
                   
                    freeSeats--; ticketsTotal++; seatsTaken++;
                       if (ticketType == "student") studentTickets++;
                       if (ticketType == "standard") standardTickets++;
                       if (ticketType == "kid") kidTickets++;
                       ticketType = Console.ReadLine();
                   }
            
                  double      percent = seatsTaken*100/(Convert.ToDouble(freeSeatsConst));
                   Console.WriteLine(movieName+"-"+string.Format("{0:F2}",percent) +"% full.");
               }
            double studentPer = studentTickets * 100 / ticketsTotal;
            double standardPer = standardTickets * 100 / ticketsTotal;
            double kidsPer = kidTickets * 100 / ticketsTotal;
            
            Console.WriteLine(string.Format("{0:F2}",studentPer)+"% student tickets.");
            Console.WriteLine(string.Format("{0:F2}", standardPer) + "% standard tickets.");
            Console.WriteLine(string.Format("{0:F2}", kidsPer) + "% kids tickets.");
           
        }
    }
}
