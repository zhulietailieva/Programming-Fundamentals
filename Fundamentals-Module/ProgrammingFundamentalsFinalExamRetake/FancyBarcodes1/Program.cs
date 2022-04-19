using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FancyBarcodes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string pattern = @"^\@{1}\#+(?<productGroup>[A-Z]+[A-Za-z0-9]{4,}[A-Z])\@{1}\#+$";
            int n = int.Parse(Console.ReadLine());
            List<Match> matches = new List<Match>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                matches.Add(match);
            }
            
            foreach (Match match in matches)
            {
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    string barcode = match.Groups["productGroup"].Value;
               
                StringBuilder productGroup = new StringBuilder(string.Empty);

                for (int i = 0; i < barcode.Length; i++)
                {
                    char c= barcode[i];
                    if (Char.IsDigit(c))
                    {
                        productGroup.Append(c);
                    }
                }
                if (productGroup.ToString().Equals(string.Empty))
                {
                        Console.WriteLine("Product group: 00");
                }
                else
                {
                    Console.WriteLine($"Product group: {productGroup.ToString()}");
                }
                }
                

            }
        }
    }
}
