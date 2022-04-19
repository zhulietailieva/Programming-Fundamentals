using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            string tryPass= Console.ReadLine();
            while (tryPass != pass)
            {
                tryPass = Console.ReadLine();

            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
