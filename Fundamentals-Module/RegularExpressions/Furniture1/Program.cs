using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            string input;
            List<string> furnitureNames = new List<string>();
            decimal totalPrice = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    decimal price =decimal.Parse( match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    totalPrice += price * quantity;
                    furnitureNames.Add(name);

                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in furnitureNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
