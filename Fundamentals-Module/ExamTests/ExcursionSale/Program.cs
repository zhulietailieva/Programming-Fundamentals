using System;

namespace ExcursionSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaHolidays = int.Parse(Console.ReadLine());
            int mountainHolidays = int.Parse(Console.ReadLine());
            double profit = 0;

            string line = Console.ReadLine();
            while (line != "Stop")
            {
                if (seaHolidays == 0 && mountainHolidays == 0)
                {
                    break;
                }
                string packageName = line;
                if (packageName == "sea")
                {
                    if (seaHolidays > 0) { 
                    seaHolidays--;
                    profit += 680;}
                }
                else
                {
                    if (mountainHolidays > 0) {
                    mountainHolidays--;
                    profit += 499; }
                }
                if (seaHolidays == 0 && mountainHolidays == 0)
                {
                    break;
                }
                line = Console.ReadLine();
            }
          
            if(seaHolidays == 0 && mountainHolidays == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
