using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    public class Student
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName,string lastName,double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string toString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int numOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfStudents; i++)
            {
                string[] studentString = Console.ReadLine().Split();
                Student newStudent = new Student(studentString[0],studentString[1],double.Parse(studentString[2]));
                students.Add(newStudent);
            }
            List<Student> sortedStudents = students.OrderBy(student => student.Grade).ToList();
            sortedStudents.Reverse();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.toString());
            }
        }
    }
}
