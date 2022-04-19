using System;

namespace OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double figurinesPrice = rent - 0.3 * rent;  
            double catering = figurinesPrice - 0.15 * figurinesPrice;
            double sounding = catering / 2.0;
            double expenses = figurinesPrice + catering + sounding+rent;
            Console.WriteLine(string.Format("{0:F2}",expenses));
        }
    }
}
