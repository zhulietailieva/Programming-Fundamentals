using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] action = line.Split().ToArray();
                if (action[0] == "Delete")
                {
                    int elementToDelete = int.Parse(action[1]);
                    while (list.Contains(elementToDelete))
                    {
                        list.Remove(elementToDelete);
                    }
                }
                else
                {
                    int elementToInsert = int.Parse(action[1]);
                    int position = int.Parse(action[2]);
                    list.Insert(position, elementToInsert);
                }
                line = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
