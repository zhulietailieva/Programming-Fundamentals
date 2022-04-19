using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int smallerLength;
            if (list1.Count < list2.Count)
            {
                smallerLength = list1.Count;
            }
            else
            {
                smallerLength = list2.Count;
            }
            for (int i = 0; i < smallerLength; i++)
            {
                result.Add(list1[i]);
                result.Add(list2[i]);

            }
            if (list1.Count < list2.Count)
            {
                for (int i = smallerLength; i < list2.Count; i++)
                {
                    result.Add(list2[i]);

                }
            }
            else if (list2.Count < list1.Count)
            {
                for (int i = smallerLength; i <list1.Count; i++)
                {
                    result.Add(list1[i]);

                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
