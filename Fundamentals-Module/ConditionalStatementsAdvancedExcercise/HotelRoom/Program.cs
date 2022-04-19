using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //May, June, July, August,  или October
            string month = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double priceS = 0;
            double priceA = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceS = 50;
                    priceA = 65;
                    if (numNights > 14)
                    {
                        priceS = 0.7 * priceS;
                        priceA = 0.9 * priceA;
                    }
                    else if (numNights > 7)
                    {
                        priceS = 0.95 * priceS;
                    }
                    priceA = numNights * priceA;
                    priceS = numNights * priceS;
                    break;
                case "June":
                case "September":
                    priceS = 72.5;
                    priceA = 68.7;
                    if (numNights > 14)
                    {
                        priceS = 0.8 * priceS;
                        priceA = 0.9 * priceA;
                    }                  
                    priceA = numNights * priceA;
                    priceS = numNights * priceS;
                    break;
                case "July":
                case "August":
                    priceS = 76;
                    priceA = 77;
                    if (numNights > 14)
                    {
                       
                        priceA = 0.9 * priceA;
                    }
                    priceA = numNights * priceA;
                    priceS = numNights * priceS;
                    break;

            }


            Console.WriteLine($"Apartment: {string.Format("{0:F2}",priceA)} lv.");
            Console.WriteLine($"Studio: {string.Format("{0:F2}", priceS)} lv.");
        }
    }
}
