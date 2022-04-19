using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int mins = 0;
            int secstotal = sec1 + sec2 + sec3;
            while (secstotal>=60)
            {
                mins++;
                secstotal -= 60;
            }

            if (secstotal < 10) Console.WriteLine($"{mins}:0{secstotal}");
            else Console.WriteLine($"{mins}:{secstotal}");
        }
    }
}
