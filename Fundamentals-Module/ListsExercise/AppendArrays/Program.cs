using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Trim().Split("|").ToArray();
            List<int> res = new List<int>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
              
                int[] arrayInt = arrays[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
               
                for (int j = 0; j < arrayInt.Length; j++)
                {
                    res.Add(arrayInt[j]);
                }
            }
            Console.WriteLine(string.Join(" ", res));
        }
    }
}
