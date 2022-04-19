using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char firstChar='0';
            char secondChar='0';
            char thirdChar='0';

            for (int i = 0; i < n; i++)
            {
                firstChar = (char)('a' + i);
                for (int j = 0; j < n; j++)
                {
                    secondChar = (char)('a' + j);
                    for (int k = 0; k < n; k++)
                    {
                        thirdChar = (char)('a' + k);
                    Console.WriteLine(firstChar+""+secondChar+""+thirdChar);
                    }                   
                }                
                
            }
        }
    }
}
