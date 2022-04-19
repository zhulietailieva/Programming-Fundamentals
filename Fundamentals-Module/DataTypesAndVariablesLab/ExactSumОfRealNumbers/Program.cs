using System;
using System.Numerics;

namespace ExactSumОfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                decimal a = decimal.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine(sum);
        }
    }
}
