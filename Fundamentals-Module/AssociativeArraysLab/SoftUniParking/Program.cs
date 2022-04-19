using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> registerList = new Dictionary<string, string>();
            for (int i = 0; i < numOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "register")
                {
                    string username = command[1];
                    string licencePlate = command[2];

                    if (registerList.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licencePlate}");
                    }
                    else
                    {
                        registerList.Add(username, licencePlate);
                        Console.WriteLine($"{username} registered {licencePlate} successfully");
                    }

                }
                else
                {
                    string username = command[1];
                    if (registerList.ContainsKey(username))
                    {
                        registerList.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }

                }
            }
            foreach (var car in registerList)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
