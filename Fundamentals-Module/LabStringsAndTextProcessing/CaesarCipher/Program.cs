using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //int symbol = 'a';
            //char newSymbol = (char)((char)symbol+3);


            string message = Console.ReadLine();
            StringBuilder encryptedMessage = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                int currChar = message[i];
                char newChar = (char)((char)currChar + 3);
                encryptedMessage.Append(newChar);

            }
            Console.WriteLine(encryptedMessage);
        }
    }
}
