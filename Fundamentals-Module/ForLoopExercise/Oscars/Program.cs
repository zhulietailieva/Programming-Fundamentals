using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            double totalPoints = academyPoints;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double points =double.Parse( Console.ReadLine());
                double pointsReceived = name.Length * points / 2;
                totalPoints += pointsReceived;
               if (totalPoints >1250.5)
                {
                    //Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {string.Format("{0:F1}", totalPoints)}!");
                    break;
                }
            }
            if (totalPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {string.Format("{0:F1}",totalPoints)}!");
                return;
            }
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {string.Format("{0:F1}",Math.Abs(1250.5-totalPoints))} more!");
            }
        }
    }
}
