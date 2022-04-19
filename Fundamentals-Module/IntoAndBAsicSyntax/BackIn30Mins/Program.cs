using System;

namespace BackIn30Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            double mins = double.Parse(Console.ReadLine());
            mins += 30;
            if (mins >= 60)
            {
                mins -=60;
                hours++;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (mins < 10) {
            Console.WriteLine($"{ hours}:0{mins}");
            }
            else
            {
                Console.WriteLine($"{ hours}:{ mins}");
            }
        }
    }
}
