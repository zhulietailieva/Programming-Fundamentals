
using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            decimal priceWithoutTax = 0;
            decimal tax = 0;
            while (line != "special" && line != "regular")
            {
                decimal priceItem = decimal.Parse(line);
                if (priceItem <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    priceWithoutTax += priceItem;
                    decimal taxItem = (decimal) 0.2 * priceItem;
                    tax += taxItem;
                }

                line = Console.ReadLine();

            }
            decimal totalPrice = priceWithoutTax + tax;
            if (line == "special")
            {
                totalPrice -=(decimal) 0.1 * totalPrice;

            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
