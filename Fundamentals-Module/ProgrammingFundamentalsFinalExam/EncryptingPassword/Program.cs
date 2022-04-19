using System;
using System.Text;
using System.Text.RegularExpressions;

namespace EncryptingPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\S+)>(?<numbers>[0-9]{3})\|(?<lowerCaseLetters>[a-z]{3})\|(?<upperCaseLetters>[A-Z]{3})\|(?<symbols>[^<>]{3})<\1$";
            int numberOfLines=int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                string tryPass=Console.ReadLine();
                Match match = Regex.Match(tryPass, pattern);
                //if the pass matches the pattern
                if (match.Success)
                {
                    StringBuilder encryptedPass=new StringBuilder();
                    encryptedPass.Append(match.Groups["numbers"].Value);
                    encryptedPass.Append(match.Groups["lowerCaseLetters"].Value);
                    encryptedPass.Append(match.Groups["upperCaseLetters"].Value);
                    encryptedPass.Append(match.Groups["symbols"].Value);
                    Console.WriteLine($"Password: {encryptedPass.ToString()}");

                }
                //if the pass is not a match
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
