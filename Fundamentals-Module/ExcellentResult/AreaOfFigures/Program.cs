using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "squre")
            {
                double a=double.Parse( Console.ReadLine());
                double s = a * a;
                Console.WriteLine(string.Format("{0:F3}",s));
            }
            if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double s = a * b;
                Console.WriteLine(string.Format("{0:F3}", s));
            }
            if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double s = r * r * Math.PI;
                Console.WriteLine(string.Format("{0:F3}", s));
            }
            if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double s = (a * h) / 2.0;
                Console.WriteLine(string.Format("{0:F3}", s));
            }



        }
    }
}
