using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOfIntegers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            SortedDictionary<int, int> resultList = new SortedDictionary<int, int>();
            for (int i = 0; i < listOfIntegers.Length; i++)
            {
                if (resultList.ContainsKey(listOfIntegers[i]))
                {
                    resultList[listOfIntegers[i]]++;
                }
                else
                {
                    resultList.Add(listOfIntegers[i], 1);
                }
            }
            foreach (var item in resultList)
            {
                Console.WriteLine(item.Key+" -> "+item.Value);
            }
        }
    }
}
