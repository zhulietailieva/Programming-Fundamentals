using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    public class Arcticle
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Arcticle(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;

        }
        
        public string toString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numOfArcticles = int.Parse(Console.ReadLine());
            List<Arcticle> arcticles = new List<Arcticle>();


            for (int i = 0; i < numOfArcticles; i++)
            {
                string[] line = Console.ReadLine().Split(", ");
                string title = line[0];
                string content = line[1];
                string author = line[2];
                Arcticle newArcticle = new Arcticle(title, content, author);
                arcticles.Add(newArcticle);
            }
            string criteria = Console.ReadLine();
            if (criteria == "title")
            {
                List<Arcticle> sortedArcticles = arcticles.OrderBy(arcticle => arcticle.Title).ToList();
                foreach (var arctcile in sortedArcticles)
                {
                    Console.WriteLine(arctcile.toString());
                }
            }
            else if (criteria == "content")
            {
                List<Arcticle> sortedArcticles = arcticles.OrderBy(arcticle => arcticle.Content).ToList();
                foreach (var arctcile in sortedArcticles)
                {
                    Console.WriteLine(arctcile.toString());
                }
            }
            else
            {
                List<Arcticle> sortedArcticles = arcticles.OrderBy(arcticle => arcticle.Author).ToList();
                foreach (var arctcile in sortedArcticles)
                {
                    Console.WriteLine(arctcile.toString());
                }
            }
        }
    }
}
