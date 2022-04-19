using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<string> elements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
          //  Console.WriteLine(elements.Count);
            int moves = 0;
            string line;
            while ((line=Console.ReadLine())!="end")
            {
                moves++;
                string[] indexes = line.Split().ToArray();
                int firstI = int.Parse(indexes[0]);
                int secondI = int.Parse(indexes[1]);

                if (firstI == secondI || firstI < 0 || secondI < 0 || firstI >= elements.Count || secondI >= elements.Count)
                {
                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[firstI].Equals(elements[secondI]))
                {
                    string elementFound = elements[firstI];
                    Console.WriteLine($"Congrats! You have found matching elements - {elementFound}!");
                    elements.Remove(elementFound);
                    elements.Remove(elementFound);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }

            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ",elements));

        }
    }
}
