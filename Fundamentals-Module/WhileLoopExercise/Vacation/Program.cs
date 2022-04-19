using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayMoney = double.Parse(Console.ReadLine());
            double startingMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int daysSpend = 0;
            while (startingMoney < holidayMoney) {
                if (daysSpend >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    return;
                }
            string action = Console.ReadLine();
            double sum = double.Parse(Console.ReadLine());
            switch (action)
            {
                    case "spend":
                        startingMoney -= sum;
                        days++;
                        daysSpend++;
                        if (startingMoney < 0)
                        {
                            startingMoney = 0;
                        }
                        break;
                    case "save":
                        startingMoney += sum;
                        daysSpend = 0;
                        days++;
                        break;                     
            }
}
            Console.WriteLine($"You saved the money for {days} days.");
        }
    }
}
