using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string line = Console.ReadLine();
           
                while (line != "Start")
                {
                    double money = double.Parse(line);
                    switch (money)
                    {
                        case 0.1:
                        case 0.2:
                        case 0.5:
                        case 1:
                        case 2:
                            sum += money;
                            break;
                        default:
                            Console.WriteLine($"Cannot accept {money}");
                            break;
                    }
                    line = Console.ReadLine();
                }
            while (line != "End")
            {
                switch (line)
                {
                    case "Start":
                        break;
                    case "Nuts":                       
                        if (sum-2 >= 0)
                        {
                            sum -= 2;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (sum - 0.7 >= 0)
                        {
                            sum -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (sum - 1.5 >= 0)
                        {
                            sum -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (sum - 0.8 >= 0)
                        {
                            sum -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (sum - 1 >= 0)
                        {
                            sum -= 1;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine("Change: "+ String.Format("{0:F2}",sum));
        }
    }
}
