using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string pattern = @"([@#]{1})(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";                    
            string input = Console.ReadLine();            
         MatchCollection matches=Regex.Matches(input, pattern);
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;

            }
           



                Console.WriteLine($"{matches.Count} word pairs found!");
                List<String> mirrorWords = new List<String>();
                foreach (Match match in matches)
                {
                    string word1 = match.Groups["word1"].Value;
                    string word2 = match.Groups["word2"].Value;
                    if (areMirrorWords(word1, word2))
                    {
                        string mirrorPair = word1 + " <=> " + word2;
                        mirrorWords.Add(mirrorPair);
                    }
                }
                if (mirrorWords.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
            

        }
        public static bool areMirrorWords(string word1,string word2)
        {
            StringBuilder word2Backwards = new StringBuilder();
            for (int i = word2.Length - 1; i >= 0; i--)
            {
                word2Backwards.Append(word2[i]);
            }
           
            if (word1.Equals(word2Backwards.ToString()))
            {
                return true;
            }
            return false;

        }
    }
}
 