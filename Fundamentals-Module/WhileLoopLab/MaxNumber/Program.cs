using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int max = int.MinValue;
            while (line != "Stop")
            {
                int num = int.Parse(line);
                if (num > max)
                {
                    max = num;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine( max);
        }
    }
}
