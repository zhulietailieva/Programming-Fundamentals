using System;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                string follower = Console.ReadLine();
                if (follower == "end") break;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
