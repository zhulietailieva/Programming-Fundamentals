﻿using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            const double eps= 0.000001;
            
            if (Math.Abs(a-b) < eps)
            {
                Console.WriteLine(true);
            }
            else{
                Console.WriteLine( false);
            }
        }
    }
}
