using System;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesList = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] studentAndCourse = input.Split(" : ");
                string studentName = studentAndCourse[1];
                string courseName = studentAndCourse[0];

                if (coursesList.ContainsKey(courseName))
                {
                    coursesList[courseName].Add(studentName);
                }
                else
                {
                    List<string> students = new List<string> { studentName };
                    coursesList.Add(courseName, students);
                }
                
                input = Console.ReadLine();

            }
            foreach (var course in coursesList)
            {
                Console.WriteLine($"{course.Key}: { course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
