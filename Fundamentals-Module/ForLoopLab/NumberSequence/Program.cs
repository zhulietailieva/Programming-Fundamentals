using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());

            int min = a;
            int max = a;
            for (int i = 0; i < n-1; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }

            }
            Console.WriteLine("Max number: "+max);
           Console.WriteLine("Min number: " + min);
        }
    }
}
