using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < inputWords.Length; i++)
            {
                inputWords[i] = inputWords[i].ToLower();
            }
            Dictionary<string, int> resultList = new Dictionary<string, int>();
            for (int i = 0; i < inputWords.Length; i++)
            {
                if (resultList.ContainsKey(inputWords[i]))
                {
                    resultList[inputWords[i]]++;
                }
                else
                {
                    resultList.Add(inputWords[i], 1);
                }
            }
            List<string> output = new List<string>();
            foreach (var item in resultList)
            {
                if (item.Value % 2 != 0)
                {
                    output.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
