using System;
using System.Text;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "end")
            {
                char[] lettersReversed = new char[line.Length];
                StringBuilder reversedWord = new StringBuilder();
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversedWord.Append(line[i]);
                }
              
                Console.WriteLine($"{line} = {reversedWord}");
                line = Console.ReadLine();

            }
           
        }
    }
}
