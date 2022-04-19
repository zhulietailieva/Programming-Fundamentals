using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            Console.WriteLine(FindSign(a,b,c));
        }
        static string FindSign(int a,int b,int c)
        {
            int numsLesThanZero = 0;
            if (a < 0)
            {
                numsLesThanZero++;
            }
            if (b < 0)
            {
                numsLesThanZero++;
            }
            if (c < 0)
            {
                numsLesThanZero++;
            }
            if (numsLesThanZero == 0 || numsLesThanZero == 2)
            {
                return "positive";
            }
            return "negative";
        }
    }
}
