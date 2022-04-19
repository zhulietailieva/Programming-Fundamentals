using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                printLine(i);
            }
            for (int i = number-1; i >0; i--)
            {
                printLine(i);
            }

        }
        static void printLine(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
