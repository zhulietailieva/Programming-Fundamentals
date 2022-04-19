using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int copy = n;
            int copy1 = n;
            do
            {
                int digit = copy1 % 10;
                int sumdig = 1;
                for (int i = digit; i >0; i--)
                {
                    sumdig *= i;
                }
                sum += sumdig;
                copy1 /= 10;
            } while (copy1  > 0);
            if (sum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
