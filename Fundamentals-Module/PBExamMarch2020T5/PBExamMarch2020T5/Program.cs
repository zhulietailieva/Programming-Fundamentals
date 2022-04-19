using System;

namespace PBExamMarch2020T5
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int foodeaten = 0;
            while (true)
            {
                String line = Console.ReadLine();
                if (line == "Adopted") break;
                int grams = int.Parse(line);
                foodeaten += grams;
            }
            if (foodeaten <= food*1000) Console.WriteLine($"Food is enough! Leftovers: {food*1000 - foodeaten} grams.");
            else Console.WriteLine($"Food is not enough. You need {foodeaten-food*1000} grams more.");
               
            
        }
    }
}
