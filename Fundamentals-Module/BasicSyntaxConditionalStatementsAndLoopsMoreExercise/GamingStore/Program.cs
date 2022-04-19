using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double totalSpent = 0;
            string line = Console.ReadLine();
            while(line!="Game Time")
            {
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                switch (line)
                {
                    case "OutFall 4":
                        if (money - 39.99 >= 0)
                        {
                            Console.WriteLine($"Bought {line}");
                            money -= 39.99;
                            totalSpent += 39.99;
                            if (money == 0)
                            {
                                Console.WriteLine("Out of money!");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        line = Console.ReadLine();
                        break;
                    case "CS: OG":
                        if (money - 15.99 >= 0)
                        {
                            Console.WriteLine($"Bought {line}");
                            money -= 15.99;
                            totalSpent += 15.99;
                            if (money == 0)
                            {
                                Console.WriteLine("Out of money!");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        line = Console.ReadLine();
                        break;
                    case "Zplinter Zell":
                        if (money - 19.99 >= 0)
                        {
                            Console.WriteLine($"Bought {line}");
                            money -= 19.99;
                            totalSpent += 19.99;
                            if (money == 0)
                            {
                                Console.WriteLine("Out of money!");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        line = Console.ReadLine();
                        break;
                    case "Honored 2":
                        if (money - 59.99 >= 0)
                        {
                            Console.WriteLine($"Bought {line}");
                            money -= 59.99;
                            totalSpent += 59.99;
                            if (money == 0)
                            {
                                Console.WriteLine("Out of money!");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        line = Console.ReadLine();
                        break;
                    case "RoverWatch":
                        if (money - 29.99 >= 0)
                        {
                            Console.WriteLine($"Bought {line}");
                            money -= 29.99;
                            totalSpent += 29.99;
                            if (money == 0)
                            {
                                Console.WriteLine("Out of money!");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        line = Console.ReadLine();
                        break;
                    case "RoverWatch Origins Edition":
                        if (money - 39.99 >= 0)
                        {
                            Console.WriteLine($"Bought {line}");
                            money -= 39.99;
                            totalSpent += 39.99;
                            if (money == 0)
                            {
                                Console.WriteLine("Out of money!");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        line = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        line = Console.ReadLine();
                        break;
                }
                
            }
            Console.WriteLine("Total spent: $"+string.Format("{0:F2}",totalSpent)+". Remaining: $"+ string.Format("{0:F2}", money));
        }
    }
}
