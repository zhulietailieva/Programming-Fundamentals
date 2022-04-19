using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = calculatePrice(product, quantity);
            Console.WriteLine($"{price:f2}"); ;
        }
        static double calculatePrice(string product, int quantity)
        {
            if (product == "coffee")
            {
                return quantity * 1.5;

            }
            else if (product == "water")
            {
                return quantity * 1;

            }
            else if (product == "coke")
            {
                return quantity * 1.4;

            }
            return quantity * 2;
        }
    }
}
