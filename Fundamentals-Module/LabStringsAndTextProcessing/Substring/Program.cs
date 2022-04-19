using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string line = Console.ReadLine();
            while (line.Contains(keyWord))
            {
               line= line.Remove(line.IndexOf(keyWord), keyWord.Length);
            }
            Console.WriteLine(line);
        }
    }
}
