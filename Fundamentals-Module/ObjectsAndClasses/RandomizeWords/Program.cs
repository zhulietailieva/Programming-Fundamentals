using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Random rand = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                string temp = words[i];
                int randIndex = rand.Next(0, words.Length);
                words[i] = words[randIndex];
                words[randIndex] = temp;
            }
            Console.WriteLine(string.Join("\n",words));
        }
    }
}
