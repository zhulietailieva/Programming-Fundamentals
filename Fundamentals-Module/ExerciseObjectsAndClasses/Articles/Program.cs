using System;

namespace Articles
{
    public class Arcticle
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Arcticle(string title,string content,string author)
        {
            Title = title;
            Content = content;
            Author = author;

        }
       public  void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;

        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
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
            string[] line = Console.ReadLine().Split(", ");
            string title = line[0];
            string content = line[1];
            string author = line[2];
            Arcticle arcticle = new Arcticle(title, content, author);
        //    Console.WriteLine(arcticle.toString());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string arcticleString = Console.ReadLine();
                string[] command = arcticleString.Split();
                if (command[0] == "Edit:")
                {
                    string newContent = arcticleString.Substring(arcticleString.IndexOf(":") + 2);
                    arcticle.Edit(newContent);
                 //   Console.WriteLine(arcticle.toString());

                }
                else if (command[0] == "ChangeAuthor:")
                {
                    string newAuthor = arcticleString.Substring(arcticleString.IndexOf(":") + 2);
                    arcticle.ChangeAuthor(newAuthor);
                //    Console.WriteLine(arcticle.toString());

                }
                else
                {
                    string newTitle = arcticleString.Substring(arcticleString.IndexOf(":") + 2);
                    arcticle.Rename(newTitle);
                   // Console.WriteLine(arcticle.toString());

                }
            }
            Console.WriteLine(arcticle.toString());
        }
    }
}
