using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(printSmallest(a,b,c));

        }
        static int printSmallest(int a,int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            return c;
        }
    }
}
