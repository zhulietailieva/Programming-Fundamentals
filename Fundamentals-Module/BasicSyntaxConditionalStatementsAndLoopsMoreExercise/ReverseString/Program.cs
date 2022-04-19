using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            for (int i = line.Length-1; i >=0; i--)
            {
                Console.Write( line.ToCharArray()[i]);
            }
        }
    }
}
