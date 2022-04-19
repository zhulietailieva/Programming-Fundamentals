using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < values.Count/2; i++)
            {
                int newValue = values[i] + values[values.Count - 1 - i];
                result.Add(newValue);
            }
            if (values.Count % 2 != 0)
            {
                result.Add(values[values.Count / 2 ]);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
