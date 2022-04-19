using System;
using System.Linq;

namespace FriendListMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ").ToArray();
            int lostNames = 0;
            int blacklistedNames = 0;

            string command;
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] action = command.Split().ToArray();

                if (action[0] == "Blacklist")
                {
                    string name = action[1];
                    bool isFound = false;
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            names[i] = "Blacklisted";
                            Console.WriteLine($"{name} was blacklisted.");
                            blacklistedNames++;
                            isFound = true;
                            break;
                        }
                    }
                    if (!isFound)
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (action[0]=="Error")
                {
                    int index = int.Parse(action[1]);

                    if (index > -1 && index < names.Length)
                    {
                        string username = names[index];
                        if (username != "Blacklisted" && username != "Lost")
                        {
                            names[index] = "Lost";
                            lostNames++;
                            Console.WriteLine($"{username} was lost due to an error.");
                        }
                    }
                }
                else
                {
                    int index = int.Parse(action[1]);
                    string newName = action[2];

                    if (index > -1 && index < names.Length)
                    {
                        string oldName = names[index];
                        names[index] = newName;
                        Console.WriteLine($"{oldName} changed his username to {newName}.");
                    }
                }
            }
            Console.WriteLine($"Blacklisted names: {blacklistedNames}");
            Console.WriteLine($"Lost names: {lostNames}");
            Console.WriteLine(string.Join(" ",names));
        }
    }
}
