using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int iCopy=i;
                while (iCopy > 0)
                {
                    sumOfDigits += iCopy % 10;
                    iCopy /= 10;
                }
                bool isSpecial = (sumOfDigits == 5)|| (sumOfDigits == 7)|| (sumOfDigits == 11);
                Console.WriteLine(i+" -> "+(isSpecial));

            }
        }
    }
}
