using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += a;

                }
                else
                {
                    sumOdd += a;
                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+sumEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " +Math.Abs(sumOdd-sumEven));
            }
        }
    }
}
