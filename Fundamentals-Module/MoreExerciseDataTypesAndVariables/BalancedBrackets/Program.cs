using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openingBrackets = 0;
            int closingBrackets = 0;
            int consecutive = 0;
            int uu = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                if (line == "(")
                {
                    openingBrackets++;
                    consecutive++;
                }
                else if (line == ")")
                {
                    closingBrackets ++;
                    consecutive = 0;

                }
                if (consecutive == 2)
                {
                    uu++;
                }
                if (openingBrackets == 0 && closingBrackets == 1)
                {
                    uu++;
                }
            }
            if (uu>0)
            {
                Console.WriteLine("UNBALANCED");
            }
           else if (openingBrackets == closingBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
