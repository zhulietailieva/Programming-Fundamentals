
using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> startList = Console.ReadLine().Split().Select(int.Parse).ToList();
          //  List<decimal> newList = new List<decimal>();

            for (int i = 0; i < startList.Count-1; i++)
            {
                if (startList[i] == startList[i + 1])
                {
                    startList.Insert(startList[i] * 2,i);
                    startList.RemoveAt(startList[i+1]);
                }
            }
            Console.WriteLine(string.Join(" ",startList));
        }
    }
}
