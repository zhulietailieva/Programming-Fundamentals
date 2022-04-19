using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //banana / apple / orange / grapefruit / kiwi / pineapple / grapes
            string fruit = Console.ReadLine();
            //Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0;
            switch (fruit)
            {
                case "banana":
                switch (day)
            {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            sum = quantity * 2.5;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        case "Saturday":
                        case "Sunday":
                            sum = quantity * 2.7;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
            }
                    break;
                case "apple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            sum = quantity * 1.2;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        case "Saturday":
                        case "Sunday":
                            sum = quantity * 1.25;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "orange":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            sum = quantity * 0.85;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        case "Saturday":
                        case "Sunday":
                            sum = quantity * 0.9;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapefruit":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            sum = quantity * 1.45;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        case "Saturday":
                        case "Sunday":
                            sum = quantity * 1.6;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "kiwi":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            sum = quantity * 2.7;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        case "Saturday":
                        case "Sunday":
                            sum = quantity * 3;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "pineapple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            sum = quantity * 5.5;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        case "Saturday":
                        case "Sunday":
                            sum = quantity * 5.6;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapes":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            sum = quantity * 3.85;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        case "Saturday":
                        case "Sunday":
                            sum = quantity * 4.2;
                            Console.WriteLine(string.Format("{0:F2}", sum));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
            

        }
    }
}
