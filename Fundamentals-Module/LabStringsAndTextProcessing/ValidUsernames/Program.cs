using System;
using System.Collections.Generic;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();
            foreach (var name in usernames)
            {
                if (IsValid(name))
                {
                    validUsernames.Add(name);

                }
            }
            foreach (var name in validUsernames)
            {
                Console.WriteLine(name);
            }
        }
        public static Boolean IsValid(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }
            for (int i = 0; i < username.Length; i++)
            {
                char letter = username[i];
                if ((letter + 0 < 65 || letter + 0 > 90) && (letter + 0 < 97 || letter + 0 > 122) &&
                    (letter + 0 < 48 || letter + 0 > 57) &&
                    letter != '-' && letter != '_')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
