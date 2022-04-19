using System;

namespace PBExamTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfLugOver20 = double.Parse(Console.ReadLine());
            while (priceOfLugOver20 < 10.0 || priceOfLugOver20 > 80.0)
            {
                Console.WriteLine("Invalid data, please try again");
                priceOfLugOver20 = double.Parse(Console.ReadLine());
            }
            double luggageKilos = double.Parse(Console.ReadLine());
            while (luggageKilos < 1.0 || luggageKilos > 32.0)
            {
                Console.WriteLine("Invalid data, please try again");
                luggageKilos = double.Parse(Console.ReadLine());
            }
            int days = int.Parse(Console.ReadLine());
            while (days < 1 || days > 60)
            {
                Console.WriteLine("Invalid data, please try again");
                days = int.Parse(Console.ReadLine());
            }
            int numberOfBags = int.Parse(Console.ReadLine());
            while (numberOfBags < 1 || numberOfBags > 10)
            {
                Console.WriteLine("Invalid data, please try again");
                numberOfBags = int.Parse(Console.ReadLine());
            }
            double priceLugg;
            if (luggageKilos < 10) priceLugg = (20 * priceOfLugOver20) / 100;
            else if (luggageKilos >= 10 && luggageKilos <= 20) priceLugg = (50 * priceOfLugOver20) / 100;
            else priceLugg = priceOfLugOver20;

            double finalPrice;
            if (days > 30) finalPrice = priceLugg + (10 * priceLugg) / 100;
            else if(days<=30&&days>=7) finalPrice = priceLugg + (15 * priceLugg) / 100;
            else finalPrice = priceLugg + (40 * priceLugg) / 100;
            Console.WriteLine(" The total price of bags is: "+string.Format("{0:F2}",finalPrice*numberOfBags) +"lv. ");
        }
    }
}
