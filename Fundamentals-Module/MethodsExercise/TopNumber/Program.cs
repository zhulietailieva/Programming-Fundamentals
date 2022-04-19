using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (isTop(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool isTop(int number)
        {
            int oddDigits = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                if (number.ToString().ToCharArray()[i] % 2 != 0)
                {
                    oddDigits++;
                    break;
                }
            }
            if (oddDigits == 0)
            {
                return false;
            }

            int sumOfDigits = 0;
            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            if (sumOfDigits % 8 != 0)
            {
                return false;
            }
            return true;
            
        }
    }
}
