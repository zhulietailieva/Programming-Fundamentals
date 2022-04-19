using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            if (n > 10)
            {
                Console.WriteLine($"{m} X {n} = {m*n}");
                return;
            }
            for (int i = n; i < 11; i++)
            {
                Console.WriteLine($"{m} X {i} = {m * i}");
            }
        }
    }
}
