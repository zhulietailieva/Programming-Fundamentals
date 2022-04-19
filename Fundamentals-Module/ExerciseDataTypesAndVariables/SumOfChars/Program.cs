using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)               
            {
                char a = Console.ReadLine().ToCharArray()[0];
                sum += (a + 0);
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
