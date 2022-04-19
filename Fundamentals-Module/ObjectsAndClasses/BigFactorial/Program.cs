using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger res = 1;
            for (int i = n ; i > 0; i--)
            {
                res *= i;
            }
            Console.WriteLine(res);
        }
    }
}
