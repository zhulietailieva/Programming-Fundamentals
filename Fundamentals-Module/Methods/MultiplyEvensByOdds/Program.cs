using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(getSumOfOdds(number));
            Console.WriteLine(getSumofEvens(number));
            Console.WriteLine(multiplyEvensByOdds(number));
        }
        static int getSumofEvens(int number)
        {
            int sumofEvens = 0;
            number = Math.Abs(number);
            for (int i = 0; i < number.ToString().Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    sumofEvens +=int.Parse( number.ToString().ToCharArray()[i].ToString());
                }
            }
            return sumofEvens;
        }

        static int getSumOfOdds(int number)
        {
            int sumOfOdds = 0;
            number = Math.Abs(number);
            for (int i = 0; i < number.ToString().Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    sumOfOdds += int.Parse(number.ToString().ToCharArray()[i].ToString());
                }
            }
            return sumOfOdds;
        }
        static double multiplyEvensByOdds(int n)
        {
            return getSumofEvens(n) * getSumOfOdds(n);
        }
    }
}
