using System;
using System.Text;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
           
            char firstChar = Console.ReadLine()[0];
            char secondChar = Console.ReadLine()[0];

            Console.WriteLine(getCharsInRange(firstChar,secondChar));
        }

        static string getCharsInRange(char a,char b)
        {
            if (a > b)
            {
                char temp = a;
                a = b;
                b = temp;
            }
            StringBuilder result = new StringBuilder(string.Empty);
            for (int i = a+1; i < b; i++)
            {
                char symbol = (char)i;
                result.Append(symbol  + " ");
            }
            return result.ToString();

        }
    }
}
