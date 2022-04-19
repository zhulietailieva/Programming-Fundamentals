using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());

            double time = distance * t;
            double slowing = Math.Floor(distance / 15);
            slowing *= 12.5;
            double totalTime = slowing + time;
            if (totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {string.Format("{0:F2}",totalTime)} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {string.Format("{0:F2}",Math.Abs( worldRecord-totalTime))} seconds slower.");
            }
        }
    }
}
