using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numPeople = int.Parse(Console.ReadLine());
            double sum = 0;
            switch (season)
            {
                case "Spring":
                    sum = 3000;
                    if (numPeople <= 6) sum -= 0.1 * sum;
                    else if (numPeople <= 11) sum -= 0.15 * sum;
                    else sum -= 0.25 * sum;
                    if (numPeople % 2 == 0) sum -= 0.05 * sum;
                    break;
                case "Summer":
                    sum = 4200;
                    if (numPeople <= 6) sum -= 0.1 * sum;
                    else if (numPeople <= 11) sum -= 0.15 * sum;
                    else sum -= 0.25 * sum;
                    if (numPeople % 2 == 0) sum -= 0.05 * sum;
                    break;
                case "Autumn":
                    sum = 4200;
                    if (numPeople <= 6) sum -= 0.1 * sum;
                    else if (numPeople <= 11) sum -= 0.15 * sum;
                    else sum -= 0.25 * sum;
                    break;
                case "Winter":
                    sum = 2600;
                    if (numPeople <= 6) sum -= 0.1 * sum;
                    else if (numPeople <= 11) sum -= 0.15 * sum;
                    else sum -= 0.25 * sum;
                    if (numPeople % 2 == 0) sum -= 0.05 * sum;
                    break;
            }
            if (sum <= budget)
            {
                Console.WriteLine($"Yes! You have {string.Format("{0:F2}",Math.Abs(sum-budget))} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {string.Format("{0:F2}", Math.Abs(sum - budget))} leva.");
            }
            
        }
    }
}
