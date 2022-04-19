using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int stands = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int perAddSpends= int.Parse(Console.ReadLine());
            if (stands > 7)
            {
                pricePerNight = 0.95 * pricePerNight;
            }
            double standsSum = stands * pricePerNight;
           
            double addSpends = perAddSpends *0.01* budget;
           
            double totalExpenses = standsSum + addSpends;
            
            if (totalExpenses > budget)
            {
                Console.WriteLine($"{string.Format("{0:F2}",Math.Abs(totalExpenses-budget))} leva needed.");
            }
            else
            {
                Console.WriteLine($"Ivanovi will be left with {string.Format("{0:F2}", Math.Abs(totalExpenses - budget))} leva after vacation.");

            }
        }
    }
}
