using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(calculateArea(a,b));
        }
        static double calculateArea(double a,double b)
        {
            return a * b;
        }
    }
}
