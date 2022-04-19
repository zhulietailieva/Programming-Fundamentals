using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double moneyspent ;
            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        moneyspent = 30 * budget/100;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine("Camp - "+string.Format("{0:F2}",moneyspent));
                    }
                    else if (budget <= 1000)
                    {
                        moneyspent = 40 * budget/100;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine("Camp - " + string.Format("{0:F2}", moneyspent));
                    }
                    else
                    {
                        moneyspent = 90 * budget/100;
                        Console.WriteLine($"Somewhere in Europe");
                        Console.WriteLine("Hotel - " + string.Format("{0:F2}", moneyspent));
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        moneyspent = 70 * budget/100;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine("Hotel - " + string.Format("{0:F2}",moneyspent));
                    }
                    else if (budget <= 1000)
                    {
                        moneyspent = 80 * budget/100;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine("Hotel - " + string.Format("{0:F2}", moneyspent));
                    }
                    else
                    {
                        moneyspent = 90 * budget/100;
                        Console.WriteLine($"Somewhere in Europe");
                        Console.WriteLine("Hotel - " + string.Format("{0:F2}", moneyspent));
                    }
                    break;
            }

        }
    }
}
