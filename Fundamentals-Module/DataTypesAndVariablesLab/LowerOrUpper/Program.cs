using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Console.ReadLine().ToCharArray()[0];
            if (a > 96)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
