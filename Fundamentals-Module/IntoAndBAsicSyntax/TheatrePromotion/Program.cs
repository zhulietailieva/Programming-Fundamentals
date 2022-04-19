using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            switch (day)
            {
                case "Weekday":
                    if (age < 0 || age > 122)
                    {
                        Console.WriteLine("Error!");
                    }
                   else if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine("12$");
                    }
                    else  if ( age <= 64)
                    {
                        Console.WriteLine("18$");
                    }
                    else if(age<=122)
                    {
                        Console.WriteLine("12$");
                    }
                    
                    break;
                case "Weekend":
                    if (age < 0 || age > 122)
                    {
                        Console.WriteLine("Error!");
                    }
                   else if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine("15$");
                    }
                    else if (age <= 64)
                    {
                        Console.WriteLine("20$");
                    }
                    else if (age <= 122)
                    {
                        Console.WriteLine("15$");
                    }
                   
                    break;
                case "Holiday":
                    if (age < 0 || age > 122)
                    {
                        Console.WriteLine("Error!");
                    }
                  else  if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine("5$");
                    }
                    else if (age <= 64)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (age <= 122)
                    {
                        Console.WriteLine("10$");
                    }
                    
                    break;
                    

            }
        }
    }
}
