using System;

namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double priceTotal = 0;
            for (int i = 0; i < N; i++)
            {
                double price = 0;
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                 price = (days * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                priceTotal += price;
            }
            Console.WriteLine($"Total: ${priceTotal:f2}");
        }
    }
}
