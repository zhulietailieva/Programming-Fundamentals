using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(repeatString(line,n));
        }
        static string repeatString(string word,int n)
        {
            StringBuilder result = new StringBuilder(word);
            for (int i = 0; i < n-1; i++)
            {
                result.Append(word);
            }
            return result.ToString();

        }
    }
}
