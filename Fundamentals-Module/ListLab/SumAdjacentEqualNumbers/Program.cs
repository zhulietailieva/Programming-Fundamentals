using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> values = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < values.Count-1; i++)
            {
                if (values[i] == values[i + 1])
                {
                    values[i] = 2 * values[i];
                    values.RemoveAt(i + 1);
                    i = -1;//the loop adds 1 at the end
                }
            }
            Console.WriteLine(string.Join(" ",values));
        }
    }
}
