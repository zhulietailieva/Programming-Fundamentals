using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(getSign(number));
        }
        static string getSign(int number)
        {
            if (number < 0)
            {
                return $"The number { number} is negative. ";
            }
            else if (number > 0)
            {
                return $"The number {number} is positive. ";

            }
            return $"The number {number} is zero. ";

        }
    }
}
