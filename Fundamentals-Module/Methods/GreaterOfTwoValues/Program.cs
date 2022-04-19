using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string compared = Console.ReadLine();
            if (compared == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(getMax(a,b));
            }
            else if (compared == "char")
            {
                char a = Console.ReadLine().ToCharArray()[0];
                char b= Console.ReadLine().ToCharArray()[0];
                Console.WriteLine(getMax(a, b));
            }
            else
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(getMax(a, b));
            }
        }
        static int getMax(int a,int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static char getMax(char a,char b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static string getMax(string a,string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            return b;
        }
    }
}
