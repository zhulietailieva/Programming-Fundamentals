using System;
using System.Collections.Generic;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine(1);
            }
            else if (num == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (num == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                List<int> res = new List<int> { 1, 1, 2 };
                for (int i = 2; i < num-1; i++)
                {
                    int nextNum = AddNumber(res[i], res[i - 1], res[i - 2]);
                    res.Add(nextNum);
                }
                Console.WriteLine(string.Join(" ",res));
            }

        }
        static int AddNumber(int a,int b,int c)
        {
            return a + b + c;
        }
    }
}
