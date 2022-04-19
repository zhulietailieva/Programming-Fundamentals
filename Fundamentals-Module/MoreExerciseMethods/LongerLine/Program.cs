using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ax = double.Parse(Console.ReadLine());
            double Ay = double.Parse(Console.ReadLine());
            double Bx = double.Parse(Console.ReadLine());
            double By = double.Parse(Console.ReadLine());

            double Cx = double.Parse(Console.ReadLine());
            double Cy = double.Parse(Console.ReadLine());
            double Dx = double.Parse(Console.ReadLine());
            double Dy = double.Parse(Console.ReadLine());

            double line1Length = getLineLength(Ax, Ay, Bx, By);
            double line2Length = getLineLength(Cx, Cy, Dx, Dy);

            if (line1Length < line2Length)
            {
                Console.WriteLine($"({Dx}, {Dy})({Cx}, {Cy})");
            }
            else
            {
                Console.WriteLine($"({Bx}, {By})({Ax}, {Ay})");
            }
        }
        static double GetDistance(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
        static double getLineLength(double ax,double ay,double bx,double by)
        {
            double side1 = Math.Abs(ax - bx);
            double side2 = Math.Abs(ay - by);
            return GetDistance(side1, side2);

        }//pak nsh ne bashka brat
    }
}
