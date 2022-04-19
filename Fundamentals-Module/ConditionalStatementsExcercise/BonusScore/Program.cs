using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (points <= 100) bonus += 5;
            else if (points <= 1000) bonus += 0.2 * points;
            else bonus += 0.1 * points;
            if (points % 2 == 0) bonus += 1;
            if (points % 10 == 5) bonus += 2;
            Console.WriteLine(bonus);
            Console.WriteLine(bonus+points);
        }
    }
}
