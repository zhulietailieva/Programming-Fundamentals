using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> numbers = new List<char>();
            List<char> letters = new List<char>();
            List<char> otherSymbols = new List<char>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char charr = input[i];
                if (charr + 0 > 47 && charr + 0 < 58)
                {
                    numbers.Add(charr);
                }
                else if ((charr + 0 > 64 && charr + 0 < 91) || (charr + 0 > 96 && charr + 0 < 123))
                {
                    letters.Add(charr);
                }
                else
                {
                    otherSymbols.Add(charr);
                }
            }
            Console.WriteLine(string.Join("",numbers));
            Console.WriteLine(string.Join("",letters));
            Console.WriteLine(string.Join("",otherSymbols));
        }
    }
}
