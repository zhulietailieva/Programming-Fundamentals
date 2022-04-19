using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else if (n == 2)
            {
                Console.WriteLine("1 1");
            }
            else
            {
                sequence[0] = sequence[1] = 1;
                for (int i = 2; i < n; i++)
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2];
                }
                Console.WriteLine(sequence[sequence.Length-1]);
            }
        }
    }
}
