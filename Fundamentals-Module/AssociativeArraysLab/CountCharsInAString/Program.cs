using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            for (int i = 0; i < line.Length; i++)
            {
                char currChar = line.ToCharArray()[i];
                if(currChar==' ')
                {
                    continue;
                }
                else if(charsCount.ContainsKey(currChar))
                {
                    charsCount[currChar]++;
                }
                else
                {
                    charsCount.Add(currChar, 1);
                }
            }
            foreach (var item in charsCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
