using System;

namespace CharacterMultiplier1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(MultiplyAndAdd(words[0],words[1]));
        }
        public static int MultiplyAndAdd(string s1,string s2)
        {
            int result = 0;
            bool isOneWordLonger = (s1.Length != s2.Length);
            if (s1.Length > s2.Length)
            {
                string temp = s1;
                s1 = s2;
                s2 = temp;
            }
            //s1 is the shorter word
            for (int i = 0; i < s1.Length; i++)
            {
                result += ((char)s1[i] + 0) * ((char)s2[i] + 0);
            }
            if (isOneWordLonger)
            {
                for (int i = s1.Length; i < s2.Length; i++)
                {
                    result += (char)s2[i] + 0;
                }
            }
            return result;

        }
    }
}
