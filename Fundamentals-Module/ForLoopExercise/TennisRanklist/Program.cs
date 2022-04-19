using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGames = int.Parse(Console.ReadLine());
            int gamesWon = 0;
            int startPoints = int.Parse(Console.ReadLine());
            int totalPoints = startPoints;
            for (int i = 0; i < numGames; i++)
            {
                string res = Console.ReadLine();
                switch (res)
                {
                    case "W":
                        totalPoints += 2000;
                        gamesWon++;
                        break;
                    case "F":
                        totalPoints += 1200;
                        break;
                    case "SF":
                        totalPoints += 720;
                        break;
                }              
            }
            Console.WriteLine($"Final points: {totalPoints}");
            double averageScore = (totalPoints - startPoints) / numGames;
            Console.WriteLine($"Average points: {Math.Floor(averageScore)}");
            double perWonGames = (gamesWon*1.0 / numGames * 100.0);
            Console.WriteLine(string.Format("{0:F2}",perWonGames ) + "%");
        }
    }
}
