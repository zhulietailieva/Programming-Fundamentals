using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 0;
            int fails = 0;
            double average=0;
            while (grade < 12)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark < 4)
                {
                    fails++;
                    if (fails > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at { grade} grade"); 
                        return;
                    }

                }
                average += mark;
                grade++;
                
            }
           
           
                average /= 12;
                Console.WriteLine($"{name} graduated. Average grade: {string.Format("{0:F2}", average)}");
            
        }
    }
}
