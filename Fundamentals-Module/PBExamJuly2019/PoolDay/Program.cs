using System;

namespace PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());
            double entranceSum = entranceFee * people;

            double sunbedSum = sunbedPrice * (Math.Ceiling(0.75 * people));
            double umbrellaSum = umbrellaPrice * (Math.Ceiling(0.5 * people));
            double sum = entranceSum + sunbedSum + umbrellaSum;
            Console.WriteLine( string.Format("{0:F2}",sum) +" lv.");
        }
    }
}
