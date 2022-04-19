using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power= double.Parse(Console.ReadLine());
            Console.WriteLine(powerBase(@base,power));
        }
       static double powerBase(double @base, double power)
        {
            double res = 1;
            for (int i = 0; i < power; i++)
            {
                res *= @base;
            }
            return res;
        }
    }
}
