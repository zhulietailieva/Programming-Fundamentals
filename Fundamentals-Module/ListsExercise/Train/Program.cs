using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] action = line.Split().ToArray();
                if (action[0] == "Add")
                {
                    train.Add(int.Parse(action[1]));
                }
                else
                {
                    int passengers = int.Parse(action[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + passengers <= maxCapacity)
                        {
                            train[i] += passengers;
                            break;
                        }
                    }
                }
                line = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ",train));
        }
    }
}
