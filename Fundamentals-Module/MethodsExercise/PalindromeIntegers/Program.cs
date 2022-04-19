using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "END")
            {
                int number = int.Parse(line);
                Console.WriteLine(isPaindrome(number));
                line = Console.ReadLine();
            }
        }
        static bool isPaindrome(int number)
        {
            for (int i = 0; i < number.ToString().Length/2; i++)
            {
                if(number.ToString().ToCharArray()[i]!= number.ToString().ToCharArray()[number.ToString().Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
