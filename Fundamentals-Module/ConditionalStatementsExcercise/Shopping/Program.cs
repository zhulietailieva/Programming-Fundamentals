using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            double sumN = N * 250;
            double sumM = (0.35 * sumN) * M;
            double sumP = P * (0.1*sumN);
            double sumTotal = sumM + sumN + sumP;
            if (N > M) sumTotal -= 0.15 * sumTotal;
            if (sumTotal > budget)
            {
                Console.WriteLine($"Not enough money! You need {string.Format("{0:F2}", Math.Abs( budget -sumTotal) )} leva more!");
            }
            else
            {
               Console.WriteLine($"You have {string.Format("{0:F2}",Math.Abs( sumTotal - budget ))} leva left!");
            } 
        }
    }
}
