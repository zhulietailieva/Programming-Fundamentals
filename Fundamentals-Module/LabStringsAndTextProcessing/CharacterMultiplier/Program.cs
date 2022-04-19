using System;
using System.Numerics;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string str1 = words[0];
            string str2 = words[1];
            Console.WriteLine(multiplyAndAdd(str1,str2));
        }
        public static BigInteger multiplyAndAdd(string s1,string s2)
        {
            BigInteger res = 0;
            bool areLengthsEqual = true;
            if (s1.Length != s2.Length)
            {
                areLengthsEqual = false;
                if (s1.Length > s1.Length)
                {
                    string temp = s1;
                    s1 = s2;
                    s2 = temp;
                }
            }
            for (int i = 0; i < s1.Length; i++)
            {
                char chars1 = s1[i];
                char chars2 = s2[i];
                res += ((chars1 + 0) * (chars2 + 0));
            }
            if (!areLengthsEqual)
            {
                for (int i = s1.Length; i < s2.Length; i++)
                {
                    char charToAdd = s2[i];
                    res += (charToAdd + 0);
                }
            }
                return res;
        }
    }
}
