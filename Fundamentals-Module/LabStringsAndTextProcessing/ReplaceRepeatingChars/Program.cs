using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> letters = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                letters.Add(input[i]);

            }
           
            for (int i = 0; i < letters.Count-1; i++)
            {
                if (letters[i] == letters[i + 1])
                {
                    letters.RemoveAt(i);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join("",letters));
        }
    }
}
