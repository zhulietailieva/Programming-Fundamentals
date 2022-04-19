using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Race
{
    class Program
    {

        static void Main(string[] args)
        {
            
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
          
            Dictionary<string, double> participantsAndDistance = new Dictionary<string, double>();
            foreach (var participant in participants)
            {
                participantsAndDistance.Add(participant,0);
            }
            string input;
            while ((input=Console.ReadLine())!= "end of race")
            {
                StringBuilder name = new StringBuilder();
                double distanceRan = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    char currCh = input[i];
                    //checks if the char is a letter
                    if ((currCh + 0 > 64 && currCh + 0 < 91) || (currCh + 0>96&&currCh+0<123))
                    {
                        name.Append(currCh);
                    }
                    else if (currCh + 0 > 47 && currCh + 0 < 58)
                    {
                        distanceRan += currCh-48;
                    }
                }
               
                if (participantsAndDistance.ContainsKey(name.ToString()))
                {
                    participantsAndDistance[name.ToString()] += distanceRan;
                }
            }
            
            var sortedParticipants = participantsAndDistance.OrderBy(d => d.Value).ToList();
            
            sortedParticipants.Reverse();
           
            string firstWinner = sortedParticipants[0].Key;
            string secondWinner = sortedParticipants[1].Key;
            string thirdWinner = sortedParticipants[2].Key;

            Console.WriteLine(@$"1st place: {firstWinner}
2nd place: {secondWinner}
3rd place: {thirdWinner}");
        }
    }
}
