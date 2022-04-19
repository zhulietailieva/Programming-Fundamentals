using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n*2; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    leftSum += a;
                }
                else
                {
                    rightSum +=a;
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = "+rightSum);
            }
            else
            {
                Console.WriteLine("No, diff = "+Math.Abs(leftSum-rightSum));
            }
        }
    }
}
