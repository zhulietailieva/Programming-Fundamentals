﻿using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Length: ");
            double   length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
         double   width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
          double  V = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {V:f2}");

        }
    }
}
//80/100 time limit?
