using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                if (n % 3 == 0)
                {
                    if (n % 5 == 0)
                    {
                        Console.WriteLine("The number is divisible by 10");
                        return;
                    }
                    Console.WriteLine("The number is divisible by 6");
                    return;
                }
                if (n % 5 == 0)
                {
                    Console.WriteLine("The number is divisible by 10");
                    return;
                }

                else if (n % 7 == 0)
                {
                    Console.WriteLine("The number is divisible by 7");
                    return;
                }
                else
                    {
                    Console.WriteLine("The number is divisible by 2");
                    return;
                    }
               
            }
           else if (n % 3 == 0)
            {
                 
               if (n % 7 == 0)
                {
                    Console.WriteLine("The number is divisible by 7");
                    return;
                }
                Console.WriteLine("The number is divisible by 3");
                return;
            }
            
            else if (n%7==0)
            {
                Console.WriteLine("The number is divisible by 7");
                return;
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
