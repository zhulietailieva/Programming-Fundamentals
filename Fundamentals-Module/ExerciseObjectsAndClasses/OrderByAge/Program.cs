using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public Person(string name,string id,int age)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public string toString()
        {
            string res= $"{Name} with ID: {Id} is {Age} years old.";
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string name = input.Split()[0];
                string id= input.Split()[1];
                int age=int.Parse(input.Split()[2]);
                bool doesPersonExist = false;
                for (int i = 0; i < people.Count; i++)
                {
                    if (id == people[i].Id)
                    {
                        doesPersonExist = true;
                        people[i].Name = name;
                        people[i].Age = age;
                    }
                }
                if (!doesPersonExist)
                {
                people.Add(new Person(name, id, age));
                }
            }
            List<Person> sortedPeople = people.OrderBy(person => person.Age).ToList();
            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.toString());
            }
        }
    }
}
