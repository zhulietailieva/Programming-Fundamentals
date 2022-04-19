using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = "";
            for (int i = username.Length-1; i >=0 ;i-- )
            {
                pass += username.ToCharArray()[i];

            }
            string line = Console.ReadLine();
            int cnt = 0;
            while (line != pass)
            {
                if (cnt == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                cnt++;
                line = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
