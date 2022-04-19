using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                bool biggerThanTheOthers = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        biggerThanTheOthers = false;
                        break;                      
                    }                    
                }
                if (biggerThanTheOthers)
                {
                    Console.Write(arr[i] + " ");
                }

            }
        }
    }
}
