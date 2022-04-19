using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(SubstractNumbers(AddNumbers(a,b),c));

        }
        static int AddNumbers(int a,int b)
        {
            return a + b;
        }
        static int SubstractNumbers(int a,int b)
        {
            return a - b;
        }
    }
}
