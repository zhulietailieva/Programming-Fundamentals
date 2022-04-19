using System;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            String footballTeamName = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());
            int teamPoints = 0;
            int gamesWon = 0;
            int gamesLost = 0 ;
            int drafts = 0;


            for (int i = 0; i < gamesPlayed; i++)
            {
                char res = Console.ReadLine()[0];
                if (res == 'W')
                {
                    teamPoints += 3;
                    gamesWon++;
                }
                else if (res == 'D')
                {
                    teamPoints += 1;
                    drafts++;
                }
                else
                {
                    gamesLost++;
                }
            }
            if (gamesPlayed == 0)
            {
                Console.WriteLine($"{footballTeamName} hasn't played any games during this season.");
            }
            else
            {
            double winRate = gamesWon * 100 / (gamesPlayed * 1.0);
                Console.WriteLine($"{footballTeamName} has won {teamPoints} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {gamesWon}");
                Console.WriteLine($"## D: {drafts}");
                Console.WriteLine($"## L: {gamesLost}");
                Console.WriteLine($"Win rate: {string.Format("{0:F2}",winRate)}%");
           

            }
            

        }
    }
}
