using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(findMiddle(word));
        }
        static string findMiddle(string word)
        {
            if (word.Length % 2 != 0)
            {
                int middle = word.Length / 2;
                char letter = word.ToCharArray()[middle];
                return letter + "";
            }
            else
            {
                int middle = word.Length / 2;
                return word.ToCharArray()[middle - 1] + "" + word.ToCharArray()[middle];
            }

        }
    }
}
