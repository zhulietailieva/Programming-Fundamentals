using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string line = Console.ReadLine();

            while (line != "NoMoreMoney")
            {
                double money = double.Parse(line);
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine("Increase: "+ string.Format("{0:F2}", money));
                sum += money;
                line = Console.ReadLine();

            }
            Console.WriteLine("Total: "+ string.Format("{0:F2}", sum));
        }
    }
}
