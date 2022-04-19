using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    public class Team
    {
        public string Leader { get; set; }
        public string  Name { get; set; }
        public List<string> Members = new List<string>();
        public Team(string leader,string name)
        {
            Leader = leader;
            Name = name;

        }
        public void AddMember(string name)
        {
            Members.Add(name);
        }
        public void toString()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"- {Leader}");
            foreach (var member in Members)
            {
                Console.WriteLine($"-- {member}");
            }
        }
        public string toStringDisbaned()
        {
            return Name;
        }
        public bool ContainsName(string teamName)
        {
            if (Name == teamName)
            {
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>(numOfTeams);
            for (int i = 0; i < numOfTeams; i++)
            {
                string[] line = Console.ReadLine().Split("-");
                string newLeader = line[0];
                string newName = line[1];
                bool isCorr = true;
                for (int j = 0; j < teams.Count; j++)
                {
                    if (newLeader == teams[j].Leader)
                    {
                        Console.WriteLine($"{newLeader} cannot create another team!");
                        isCorr = false;
                        break;
                    }
                    if (newName == teams[j].Name)
                    {
                        Console.WriteLine($"Team {newName} was already created!");
                        isCorr = false;
                        break;
                    }              
                }
                if (isCorr)
                {
                    teams.Add(new Team(line[0], line[1])); 
                    Console.WriteLine($"Team {newName} has been created by {newLeader}!");
                }               
            }
            string newLine;
            while ((newLine = Console.ReadLine())!= "end of assignment") {
                string[] memberAndTeam = newLine.Split("->").ToArray();
                string newMember = memberAndTeam[0];
                string newTeamName = memberAndTeam[1];
                bool doesTeamExist = false;
               
                foreach (var team in teams)
                {
                    if (team.Name == newTeamName)
                    {
                        doesTeamExist = true;
                        break;
                    }
                }
                if (!doesTeamExist)
                {
                    Console.WriteLine($"Team {newTeamName} does not exist!");
                    continue;
                }
                //we already know that a team eith this name exists
                bool isMemberOfAnotherTeam = false;
                foreach (var team in teams)//see if the new member is a leader of a team already
                {
                    if (team.Leader == newMember)
                    {
                        isMemberOfAnotherTeam = true;
                        break;
                    }
                }
                if (isMemberOfAnotherTeam)
                {
                    Console.WriteLine($"Member {newMember} cannot join team {newTeamName}!");
                    continue;
                }

                for (int i = 0; i < teams.Count; i++)
                {
                    if (teams[i].Name == newTeamName)
                    {
                        teams[i].AddMember(newMember);
                    }
                } 

           }
            List<Team> disbandTeams = new List<Team>();
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Members.Count == 0)
                {
                    disbandTeams.Add(teams[i]);
                    teams.RemoveAt(i);
                }
            }
            List<Team> disbandTeamsSorted = disbandTeams.OrderBy(team => team.Name).ToList();
            List<Team> sortedTeams = teams.OrderBy(team => team.Name).ToList();

            foreach (var team in sortedTeams)
            {
                List<string> sortedMembers = (team.Members).OrderBy(name => name).ToList();
                team.Members = sortedMembers;
            }
            foreach (var team in sortedTeams)
            {
                team.toString();
            }
            
 Console.WriteLine("Teams to disband:");
            if (disbandTeamsSorted.Count > 0)
            {
                foreach (var team in disbandTeamsSorted)
                {
                    Console.WriteLine(team.toStringDisbaned());
                }
            }
           
            
        }
    }
}
