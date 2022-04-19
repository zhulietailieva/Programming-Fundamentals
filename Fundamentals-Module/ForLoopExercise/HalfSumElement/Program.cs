using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums =new int[n];
            int sum = 0;
            int max = int.MinValue;
            
            for (int i = 0; i < n; i++)
            {
                
                int a = int.Parse(Console.ReadLine());
                if (a > max)
                {
                    max = a;
                }
                nums[i] = a;
                sum += a;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == (sum - nums[i]))
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = "+nums[i]);
                    return;
                }
            }
            Console.WriteLine("No");
            Console.WriteLine("Diff = " +Math.Abs(((sum-max)-max)));
        }
    }
}
