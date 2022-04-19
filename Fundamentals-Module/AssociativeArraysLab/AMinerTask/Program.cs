using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesList = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (resourcesList.ContainsKey(resource))
                {
                    resourcesList[resource] += quantity;
                }
                else
                {
                    resourcesList.Add(resource, quantity);
                }
                resource= Console.ReadLine();

            }
            foreach (var item in resourcesList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
