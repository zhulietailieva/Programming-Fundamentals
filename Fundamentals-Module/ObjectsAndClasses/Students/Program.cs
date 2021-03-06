using System;
using System.Collections.Generic;

namespace Students
{
    public class Student
    {
        public string FirstName, LastName,HomeTown;
        public int Age;

        public Student(string firstName,string lastName, int age,string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end")
            {

                string[] Allstudents = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = Allstudents[0];
                string lastName = Allstudents[1];
                int age = int.Parse(Allstudents[2]);
                string homeTown = Allstudents[3];
                Student student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);

                line = Console.ReadLine();

            }
            string town = Console.ReadLine();
            List<Student> filteredStudents = students.FindAll(student => student.HomeTown == town);
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
