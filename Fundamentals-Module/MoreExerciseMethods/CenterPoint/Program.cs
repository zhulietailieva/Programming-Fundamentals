using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double distance1 = GetDistance(x1, y1);
            double distance2 = GetDistance(x2, y2);
            if (distance1 > distance2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
        static double GetDistance(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
