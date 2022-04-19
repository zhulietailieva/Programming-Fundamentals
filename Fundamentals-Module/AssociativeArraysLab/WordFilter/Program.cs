using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] filteredWords= inputWords.Where(item => item.Length%2==0).ToArray();
            foreach (var item in filteredWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
