using System;
using System.Collections.Generic;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> chars = new List<char>(input);
            StringBuilder output = new StringBuilder();

            int bombPower = 0;
            for (int i = 0; i < chars.Count; i++)
            {
                char currChar = chars[i];
                if (currChar == '>')
                {
                    output.Append(currChar);
                    bombPower += (int)chars[i + 1] - 48;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                        continue;
                    }
                    else
                    {
                        output.Append(currChar);
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
