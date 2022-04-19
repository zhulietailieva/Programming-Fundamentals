using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            long getFatc1 = GetFactorial(firstNum);
            long getFatc2 = GetFactorial(secondNum);

            double result = getFatc1 / (getFatc2 * 1.0);
            Console.WriteLine($"{result:f2}");
        }
        static long GetFactorial(int number)
        {


            //if (number < 0)
            //{
            //    number = Math.Abs(number);
            //    long res = 1;
            //    for (int i = number; i > 0; i--)
            //    {
            //        res *= i;
            //    }
            //    return res * -1;
            //}
            //else
            {
                long res = 1;
                for (int i = number; i > 0; i--)
                {
                    res *= i;
                }
                return res;
            }

        }
    }
}
