using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            string packageName = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int stayTime = int.Parse(Console.ReadLine());
            double sum = 0;
            if (stayTime < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            if ((cityName != "Bansko" && cityName != "Borovets" && cityName != "Varna" && cityName != "Burgas")||
                packageName != "noEquipment"&& packageName != "withEquipment"&& packageName != "noBreakfast"&& packageName == "withBreakfast")
            {
                Console.WriteLine("Invalid input!");
                return;
            }
              
            if (stayTime > 7)
            {
                stayTime--;
            }
            if(cityName=="Bansko"|| cityName == "Borovets")
            {
                if(packageName != "noEquipment"&& packageName != "withEquipment")
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
               if(packageName== "noEquipment")
                {
                    sum += 80 * stayTime;
                }
               else if (packageName == "withEquipment")
                {
                    sum += 100 * stayTime;
                }
                if (vipDiscount == "yes")
                {
                    if(packageName== "withEquipment")
                    {
                        sum -= 0.1 * sum;
                    }
                    else if(packageName == "noEquipment")
                    {
                        sum -= 0.05 * sum;
                    }
                }
                Console.WriteLine($"The price is {string.Format("{0:F2}",sum)}lv! Have a nice time!");
            }


            if (cityName == "Varna" || cityName == "Burgas")
            {
                if(packageName!= "noBreakfast"&& packageName != "withBreakfast")
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
                if (packageName == "noBreakfast")
                {
                    sum += 100 * stayTime;
                }
                else if (packageName == "withBreakfast")
                {
                    sum += 130 * stayTime;
                }
                if (vipDiscount == "yes")
                {
                    if (packageName == "withBreakfast")
                    {
                        sum -= 0.12 * sum;
                    }
                    else if (packageName == "noBreakfast")
                    {
                        sum -= 0.07 * sum;
                    }
                }
                Console.WriteLine($"The price is {string.Format("{0:F2}", sum)}lv! Have a nice time!");
            }
            


        }
    }
}
