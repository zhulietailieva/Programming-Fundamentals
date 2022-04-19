using System;

namespace TimeAfter15Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            if (mins / 10 > 0)
            {
                if (mins % 100 == 0) mins = mins % 10;
            }

            if (mins >= 45)
            {
                if (hours == 23)
                {
                    hours = 0; mins -= 45;
                }
                hours++; mins -= 45;
            }
            else mins += 15;
            if (mins < 10)
            {
                Console.WriteLine($"{hours}:0{mins}");
            }
            else
            {
                Console.WriteLine($"{hours}:{mins}");
            }
        }
    }
}
