using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {

           // string text = ">>Chair<<412.23!3";
            //string remainingPartOfText = text.Substring(text.IndexOf("!"));
            //string priceText = text.Substring(text.LastIndexOf("<") + 1);
            //priceText = priceText.Substring(0, priceText.Length - remainingPartOfText.Length);
            //Console.WriteLine(priceText);
            //if (!priceText.Contains("."))
            //{
            //    decimal priceInTotal = decimal.Parse(priceText);
            //}
            //else
            //{
            //    decimal wholePart =decimal.Parse( priceText.Substring(0, priceText.Length - 3));
            // //   Console.WriteLine(wholePart);
            //    decimal decimalPart = decimal.Parse(priceText.Substring(priceText.Length - 3));
            //  //  Console.WriteLine(decimalPart);
            //    decimal priceInTotal = wholePart + decimalPart;
            //  //  Console.WriteLine(priceInTotal);
            //}



            string pattern = @">>[A-Z]+[a-z]*<<([0-9]+(.[0-9]+)*)![0-9]+";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            StringBuilder regexString = new StringBuilder();

            while (input != "Purchase")
            {
                regexString.Append(input);
                regexString.Append("\n");
                input = Console.ReadLine();
            }
            MatchCollection matches = regex.Matches(regexString.ToString());
            List<string> matchedFurniture = new List<string>();

            foreach (Match match in matches)
            {
                matchedFurniture.Add(match.Value);

            }
            decimal totalPrice = 0;
            List<string> funritureItems = new List<string>();

            foreach (var itemOfFurniture in matchedFurniture)
            {
                string remainingPart = itemOfFurniture.Substring(itemOfFurniture.IndexOf("<"));
                string name = itemOfFurniture.Substring(2, itemOfFurniture.Length - remainingPart.Length - 2);
                funritureItems.Add(name);
                //   double price=
                string remainingPartOfText = itemOfFurniture.Substring(itemOfFurniture.IndexOf("!"));
                string priceText = itemOfFurniture.Substring(itemOfFurniture.LastIndexOf("<") + 1);
                priceText = priceText.Substring(0, priceText.Length - remainingPartOfText.Length);
           //     Console.WriteLine(priceText);
                decimal priceInTotal = 0;
                if (!priceText.Contains("."))
                {
                     priceInTotal = decimal.Parse(priceText);
                }
                else
                {
                    decimal wholePart = decimal.Parse(priceText.Substring(0, priceText.Length - 3));
                    //   Console.WriteLine(wholePart);
                    decimal decimalPart = decimal.Parse(priceText.Substring(priceText.Length - 3));
                    //  Console.WriteLine(decimalPart);
                     priceInTotal = wholePart + decimalPart;
                    //  Console.WriteLine(priceInTotal);
                }
                //price
                int quantity = int.Parse(itemOfFurniture.Substring(itemOfFurniture.IndexOf("!") + 1));
                decimal priceForTheQuantity = quantity * priceInTotal;
                totalPrice += priceForTheQuantity ;
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in funritureItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalPrice}");

        }
    }
}
