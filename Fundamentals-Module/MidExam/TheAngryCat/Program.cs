using System;
using System.Collections.Generic;
using System.Linq;

namespace TheAngryCat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();

            int brokenItemsLeft = 0;
            int brokenItemsRight = 0;

            int sumOfPriceRatingsRight = 0;
            int sumOfPriceRatingsLeft = 0;

            int startingItem = items[entryPoint];

            if (typeOfItems == "cheap")
            {
                for (int i =entryPoint+1; i < items.Count; i++)
                {
                    if (items[i] < startingItem)
                    {
                        sumOfPriceRatingsRight += items[i];
                        brokenItemsRight++;
                    }
                }
                for (int i = entryPoint - 1; i >= 0; i--)
                {
                    if (items[i] < startingItem)
                    {
                        sumOfPriceRatingsLeft += items[i];
                        brokenItemsLeft++;
                    }
                }
            }
            else if (typeOfItems == "expensive")
            {
                for (int i = entryPoint + 1; i < items.Count; i++)
                {
                    if (items[i] >= startingItem)
                    {
                        sumOfPriceRatingsRight += items[i];
                        brokenItemsRight++;
                    }
                }
                for (int i = entryPoint - 1; i >= 0; i--)
                {
                    if (items[i] >= startingItem)
                    {
                        sumOfPriceRatingsLeft += items[i];
                        brokenItemsLeft++;
                    }
                }
            }

            if (brokenItemsRight > brokenItemsLeft)
            {
                Console.WriteLine($"Right - {sumOfPriceRatingsRight}");
            }
            else
            {
                Console.WriteLine($"Left - {sumOfPriceRatingsLeft}");
            }
        }
    }
}
