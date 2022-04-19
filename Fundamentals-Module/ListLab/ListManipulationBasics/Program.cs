using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] action = command.Split();
                if (action[0] == "Add")
                {
                    list.Add(int.Parse(action[1]));
                }
                else if (action[0] == "Remove")
                {
                    list.Remove(int.Parse(action[1]));
                }
                else if (action[0] == "RemoveAt")
                {                    
                        list.RemoveAt(int.Parse(action[1]));    
                }
                else if(action[0]=="Insert")
                {
                    list.Insert(int.Parse(action[2]), int.Parse(action[1]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
