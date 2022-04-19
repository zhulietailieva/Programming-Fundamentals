using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string tryBook = Console.ReadLine();
            int count = 0;
            while (tryBook != book)
            {
                if (tryBook=="No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    return;
                }
                count++;
                tryBook = Console.ReadLine();
            }
            Console.WriteLine($"You checked {count} books and found it.");
        }
    }
}
