using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] action = command.Split().ToArray();

                if (action[0] == "Shoot")
                {
                    int index = int.Parse(action[1]);
                    int power = int.Parse(action[2]);
                    if (index > -1 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (action[0] == "Add")
                {
                    int index = int.Parse(action[1]);
                    int value = int.Parse(action[2]);
                    //
                    if (index > -1 && index < targets.Count )
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else
                {
                    int index = int.Parse(action[1]);
                    int radius = int.Parse(action[2]);
                    bool isMissed = false;
                    if (index < 0 || index > targets.Count - 1)
                    {
                        isMissed = true;
                    }
                    for (int i = 0; i < radius; i++)
                    {
                        if (index - 1 - i < 0)
                        {
                            isMissed = true;
                        }
                        if (index + 1 + i > targets.Count - 1)
                        {
                            isMissed = true;
                        }
                    }
                    if (isMissed)
                    {
                        Console.WriteLine("Strike missed!");
                        
                    }
                    else
                    {
                        int element = targets[index];
                        for (int i = 0; i < radius; i++)
                        {
                            targets.RemoveAt(index - 1 - i);
                        }
                        index = targets.IndexOf(element);
                        for (int i = 0; i < radius; i++)
                        {
                            targets.RemoveAt(index + 1);
                        }
                        targets.Remove(element);
                    }
                }
            }
            Console.WriteLine(string.Join("|",targets));
        }
    }
}
