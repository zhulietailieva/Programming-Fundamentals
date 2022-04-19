using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int min = int.MaxValue;
            while (line != "Stop")
            {
                int num = int.Parse(line);
                if (num < min)
                {
                    min = num;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
