using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashM = double.Parse(Console.ReadLine());
            int toyPrice=int.Parse(Console.ReadLine());
            int numToys = 0;
            double savedSum = 0;
            int brotherTakes = 0;
            for (int i = 1,j=1;  i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedSum += 10 * j;
                    j++;
                    brotherTakes++;
                }
                else
                {
                    numToys++;
                }
            }
            savedSum = savedSum + numToys * toyPrice;
            savedSum -= brotherTakes;
            if (savedSum < priceWashM)
            {
                Console.WriteLine("No! "+string.Format("{0:F2}",Math.Abs(savedSum-priceWashM)));
            }
            else
            {
                Console.WriteLine("Yes! " + string.Format("{0:F2}", Math.Abs(savedSum - priceWashM)));
            }
        }
    }
}
