using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(getGrade(grade));
        }

        static string getGrade(double grade)
        {
            if (grade < 3)
            {
                return "Fail";

            }
            else if (grade < 3.5)
            {
                return "Poor";
            }
            else if (grade < 4.5)
            {
                return "Good";
            }
            else if (grade < 5.5)
            {
                return "Very good";
            }
            return "Excellent";
        }
    }
}
