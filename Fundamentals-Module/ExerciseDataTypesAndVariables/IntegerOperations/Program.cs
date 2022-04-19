using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            double res = ((n1 + n2) / (n3 * 1.0)) * n4;
            Console.WriteLine(res);
        }
    }
}
