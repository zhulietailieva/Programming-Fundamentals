using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = m; i <= n; i++)
            {
                char a = (char)i;

                Console.Write(a+" ");
            }
        }
    }
}
