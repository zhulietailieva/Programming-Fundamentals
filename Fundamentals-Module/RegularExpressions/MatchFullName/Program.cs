using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            Regex regex = new Regex(pattern);
            string names = Console.ReadLine();
            MatchCollection matches = regex.Matches(names);
            List<string> matchedPhones = new List<string>();

            foreach (Match match in matches)
            {
                matchedPhones.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ",matchedPhones));

        }
    }
}
