using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            if (n >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
