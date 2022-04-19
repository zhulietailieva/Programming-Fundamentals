using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int NumRotations = int.Parse(Console.ReadLine());
            while (NumRotations > 0)
            {
            int temp = arr[0];
            for (int i = 0; i < arr.Length-1; i++)
            {
            arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = temp;
                NumRotations--;
            }
        Console.WriteLine(string.Join(" ",arr));


        }
    }
}
