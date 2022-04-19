using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWords =int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordsAndSynonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < countOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (wordsAndSynonyms.ContainsKey(word))
                {
                    wordsAndSynonyms[word].Add(synonym);
                }
                else
                {
                    wordsAndSynonyms.Add(word, new List<string> { synonym });
                }
            }
            foreach (var item in wordsAndSynonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
