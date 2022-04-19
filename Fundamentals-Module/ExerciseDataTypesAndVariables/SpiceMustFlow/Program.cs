using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int spices = 0;
            while (yield >= 100)
            {
                days++;
                spices += yield;
                yield -= 10;
                if (spices >= 26)
                {
                    spices -= 26;
                }
            }
            if (spices >= 26)
            {
                spices -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(spices);
        }
    }
}
