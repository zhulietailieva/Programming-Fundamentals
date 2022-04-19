using System;

namespace PBExamMarch2020T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int numberOfWalks = int.Parse(Console.ReadLine());
            int cal = int.Parse(Console.ReadLine());
            int totalMinutesOfWalk = min * numberOfWalks;
            int caloriesBurned = totalMinutesOfWalk * 5;
            double halfCalIntake = cal / 2;
            if (caloriesBurned >= halfCalIntake) Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            else Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
        }
    }
}
