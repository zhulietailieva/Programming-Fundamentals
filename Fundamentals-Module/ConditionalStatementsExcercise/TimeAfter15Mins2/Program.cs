using System;

namespace TimeAfter15Mins2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            if (mins >= 45)
            {
                mins -= 45;
                if (hours == 23)
                {
                    hours = 0;
                }
                else {
                hours++; 
                }
                Console.WriteLine($"{hours}:{mins:d2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{(mins + 15):d2}");
            }
        }
    }
}
