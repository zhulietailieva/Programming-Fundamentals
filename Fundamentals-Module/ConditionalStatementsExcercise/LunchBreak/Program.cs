using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvSeries = Console.ReadLine();
            int epDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());
            double freeTime  = breakDuration / 4.0;
            double lunch = breakDuration / 8.0;
            double timeLeft = breakDuration - freeTime - lunch;
            if (timeLeft >= epDuration)
            {
                Console.WriteLine($"You have enough time to watch {tvSeries} and left with {Math.Ceiling(timeLeft-epDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {tvSeries}, you need {Math.Ceiling(epDuration - timeLeft)} more minutes.");
            }
        }
    }
}
