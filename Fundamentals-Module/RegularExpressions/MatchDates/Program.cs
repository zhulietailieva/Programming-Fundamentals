using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[0-9]{2}(?:(.|-|\/))[A-Z][a-z]{2}\1[0-9]{4}";
            Regex regex = new Regex(pattern);
            string textDates = Console.ReadLine();
            MatchCollection matches = regex.Matches(textDates);
            //"Day: {day}, Month: {month}, Year: {year}", each on a new line.
           List<string> matchedDates = new List<string>();
            foreach (Match match in matches)
            {
                matchedDates.Add(match.Value);
            }
            foreach (var dateMatch in matchedDates)
            {
                char delimiter = dateMatch.ToCharArray()[2];
                string[] splitDate = dateMatch.Split(delimiter);
                string day = splitDate[0];
                string month = splitDate[1];
                string year = splitDate[2];
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
