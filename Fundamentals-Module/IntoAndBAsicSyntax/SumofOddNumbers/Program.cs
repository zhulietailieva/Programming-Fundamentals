using System;

namespace SumofOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int cnt = 0;
            for (int i = 0; cnt< n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    cnt++;
                }
                
            }
            Console.WriteLine("Sum: "+sum);
        }
    }
}
