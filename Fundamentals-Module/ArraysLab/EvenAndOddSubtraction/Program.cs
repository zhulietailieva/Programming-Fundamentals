using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
           
            int sumE = 0;
            int sumO = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                   
                    sumE += arr[i];
                }
                else
                {
                    
                    sumO += arr[i];
                }
            }
           
           
            
                Console.WriteLine(sumE-sumO);
            
           
        }

    }
}