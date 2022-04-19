using System;

namespace TravelAgency2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            string package = Console.ReadLine();
            string discount = Console.ReadLine();
            int daysStay = int.Parse(Console.ReadLine());
            if (daysStay < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            double price = 0;
            if (daysStay > 7)
            {
                daysStay--;
            }

            switch (cityName)
            {
                
                case "Borovets":
                case"Bansko" :
                    switch (package)
                    {
                        case "withEquipment":
                            price = daysStay * 100;
                            if (discount == "yes")
                            {
                                price -= 0.1 * price;
                            }
                            Console.WriteLine($"The price is {string.Format("{0:F2}", price)}lv! Have a nice time!");
                            break;
                        case "noEquipment":
                            price = daysStay * 80;
                            if (discount == "yes")
                            {
                                price -= 0.05 * price;
                            }
                            Console.WriteLine($"The price is {string.Format("{0:F2}", price)}lv! Have a nice time!");
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                    break;
                case "Varna":
                case "Burgas":
                    switch (package)
                    {
                        case "withBreakfast":
                            price = daysStay * 130;
                            if (discount == "yes")
                            {
                                price -= 0.12 * price;
                            }
                            Console.WriteLine($"The price is {string.Format("{0:F2}", price)}lv! Have a nice time!");
                            break;
                        case "noBreakfast":
                            price = daysStay * 100;
                            if (discount == "yes")
                            {
                                price -= 0.07 * price;
                            }
                            Console.WriteLine($"The price is {string.Format("{0:F2}", price)}lv! Have a nice time!");
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
           
        }
    }
}
