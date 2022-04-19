using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(countVowels(word));
        }
        static int countVowels(string word)
        {
            int vowels = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word.ToCharArray()[i];
                if(letter=='a'||letter=='A'|| letter == 'U' || letter == 'u' || letter == 'e' || letter == 'E' ||
                    letter == 'O' || letter == 'o' || letter == 'i' || letter == 'I')
                {
                    vowels++;
                }
            }
            return vowels;
        }
    }
}
