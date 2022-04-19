using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string line = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                while (line.Contains(word))
                {
                    string bannedWord = string.Empty;
                    for (int i = 0; i < word.Length; i++)
                    {
                        bannedWord += "*";
                    }
                    line = line.Replace(word,bannedWord );
                }
            }
            Console.WriteLine(line);
        }
    }
}
