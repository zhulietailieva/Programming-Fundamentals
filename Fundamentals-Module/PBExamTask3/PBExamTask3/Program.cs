using System;

namespace PBExamTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            String kindOfJoinery = Console.ReadLine();
            String wayOfPayment = Console.ReadLine();
            if(num<10)
            {
                Console.WriteLine("Invalid order");
                return;
            }double price;        
            double finalPrice=0;
           if(kindOfJoinery== "90X130")
            {
                price = num * 110;
                if (num > 30&&num<=60) finalPrice = price - (5 * price )/ 100;
               else if(num>60) finalPrice = price - (8 * price) / 100;
            }
           else if(kindOfJoinery== "100X150")
            {
                price = num * 140;
                if (num > 40 && num <= 80) finalPrice = price - (6 * price) / 100;
                else if (num > 80) finalPrice = price - (10 * price) / 100;
            }
            else if (kindOfJoinery == "130X180")
            {
                price = num * 190;
                if (num > 20 && num <= 50) finalPrice = price - (7 * price) / 100;
                else if (num > 50) finalPrice = price - (12 * price) / 100;
            }
            else if (kindOfJoinery == "200X300")
            {
                price = num * 250;
                if (num > 25 && num <= 50) finalPrice = price - (9 * price) / 100;
                else if (num > 50) finalPrice = price - (14 * price) / 100;
            }
            if (wayOfPayment == "With delivery") finalPrice += 60;
            if (num > 99) finalPrice = finalPrice -( 4 * finalPrice) / 100;
            Console.WriteLine(string.Format("{0:F2}",finalPrice) + " BGN");
        }
    }
}
