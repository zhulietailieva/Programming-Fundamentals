﻿using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (gender == "m" || gender == "f")
            {
                if (gender == "m")
                {
                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");

                    }
                    else
                    {
                        Console.WriteLine("Master");
                    }
                }
                else
                {
                    if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
                }
            }
        }
    }
}
