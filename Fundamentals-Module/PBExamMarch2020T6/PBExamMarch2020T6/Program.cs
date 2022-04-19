using System;

namespace PBExamMarch2020T6
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int losses = 0;
            int wins = 0;
            double sum = 0;
            int finishCount=0;
            int dayswon = 0;
            int moneyForTheDay = 0;
            while (true)
            {
                string sport = Console.ReadLine();
                if (sport == "Finish")
                {finishCount++;
                    if (wins > losses) { moneyForTheDay = moneyForTheDay + (10 * moneyForTheDay) / 100;
                        dayswon++;// Console.WriteLine(moneyForTheDay);
                        sum += moneyForTheDay;
                        moneyForTheDay = 0;
                        wins = 0;losses = 0;
                    }
                    sum += moneyForTheDay; //Console.WriteLine(moneyForTheDay);
                    moneyForTheDay = 0; wins = 0; losses = 0;
                    if (finishCount == days) break;
                    else sport = Console.ReadLine();
                }
                string res = Console.ReadLine();
                if (res == "win") { wins++; moneyForTheDay += 20; }
                else  losses++; 
            }
            if (dayswon > (days - dayswon))
            {
                sum = sum + (20 * sum) / 100;
                Console.WriteLine("You won the tournament! Total raised money: " +string.Format("{0:F2}",sum));
            }
            else Console.WriteLine($"You lost the tournament! Total raised money: " + string.Format("{0:F2}", sum));
        }
    }
}
