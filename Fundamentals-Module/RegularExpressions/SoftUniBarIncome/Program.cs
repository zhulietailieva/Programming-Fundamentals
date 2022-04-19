using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<name>[A-Z]{1}[a-z]+)%[^\.\%\|\$]*<(?<product>\w+)>[^\.\%\|\$]*\|(?<count>\d+)\|[^\.\%\|\$0-9]*(?<price>\d+(.(\d)+)?)\$$";
            List<string> customers = new List<string>();
            List<string> products = new List<string>();
            List<decimal> priceForProduct = new List<decimal>();

            decimal totalPrice = 0;
            string input = Console.ReadLine();
            while(input!= "end of shift")
            {
                
                Match match = Regex.Match(input, pattern);
              
                if (match.Success)
                {
                    customers.Add(match.Groups["name"].Value);
                    products.Add(match.Groups["product"].Value);
                    int quantity = int.Parse(match.Groups["count"].Value);
                    decimal singlePrice = decimal.Parse(match.Groups["price"].Value);
                    decimal totalPriceForProduct = singlePrice * quantity;
                    priceForProduct.Add(totalPriceForProduct);
                    totalPrice += totalPriceForProduct;

                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < customers.Count; i++)
            {
                string customer = customers[i];
                string product = products[i];
                decimal price = priceForProduct[i];
                Console.WriteLine($"{customer}: {product} - {price:f2}");

            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
