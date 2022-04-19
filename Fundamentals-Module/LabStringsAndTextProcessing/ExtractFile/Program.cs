using System;
using System.Text;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            StringBuilder name = new StringBuilder();
          
            for (int i = path.LastIndexOf('\\')+1; i < path.IndexOf('.'); i++)
            {
                name.Append(path[i]);

            }
            string extension = path.Substring(path.IndexOf('.')+1);
            Console.WriteLine($"File name: {name.ToString()}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
