using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "";


            char a = Console.ReadLine().ToCharArray()[0];

            char b = Console.ReadLine().ToCharArray()[0];
            char c = Console.ReadLine().ToCharArray()[0];
            res = a+""+b+""+c;

            Console.WriteLine(res);
        }
    }
}
