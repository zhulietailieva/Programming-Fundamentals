using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double profits = double.Parse(Console.ReadLine());
            double commission = 0;
            switch(town){
                case "Sofia":
                    if (profits < 0)
                    {
                        Console.WriteLine("error");
                        return;
                    }
                   else if (profits >= 0 && profits <= 500)
                    {
                        commission = 0.05 * profits;
                        Console.WriteLine(string.Format("{0:F2}",commission));
                        return;
                    }
                    else if (profits <= 1000)
                    {
                        commission = 0.07 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                        return;
                    }
                    else if (profits <= 10000)
                    {
                        commission = 0.08 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                        return;
                    }
                    else if (profits > 10000)
                    {
                        commission = 0.12 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                        return;
                    }
                    
                    break;
                case "Varna":
                    if (profits < 0)
                    {
                        Console.WriteLine("error");
                        return;
                    }
                 else   if (profits >= 0 && profits <= 500)
                    {
                        commission = 0.045 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                    }
                    else if (profits <= 1000)
                    {
                        commission = 0.075 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                    }
                    else if (profits <= 10000)
                    {
                        commission = 0.1 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                    }
                    else if (profits > 10000)
                    {
                        commission = 0.13 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                    }
                   
                    break;
                case "Plovdiv":
                    if (profits < 0)
                    {
                        Console.WriteLine("error");
                        return;
                    }
                  else  if (profits >= 0 && profits <= 500)
                    {
                        commission = 0.055 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                    }
                    else if (profits <= 1000)
                    {
                        commission = 0.08 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                    }
                    else if (profits <= 10000)
                    {
                        commission = 0.12 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                    }
                    else if (profits > 10000)
                    {
                        commission = 0.145 * profits;
                        Console.WriteLine(string.Format("{0:F2}", commission));
                    }
                   
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }
                 
        }
    }
}
