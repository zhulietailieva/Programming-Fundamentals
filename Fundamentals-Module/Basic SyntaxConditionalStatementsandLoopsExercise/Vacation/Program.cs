using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double sum = cnt;

            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        sum *= 8.45;
                        if (cnt >= 30)
                        {
                            sum -= 0.15 * sum;
                        }
                    }
                    else if (type == "Business")
                    {
                        sum *= 10.9;
                        if (cnt >= 100)
                        {
                            sum -= 10 * 10.9;
                        }
                    }
                    else
                    {
                        sum *= 15;
                        if (cnt >= 10 && cnt <= 20)
                        {
                            sum -= 0.05 * sum;
                        }
                    }
                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        sum *= 9.8;
                        if (cnt >= 30)
                        {
                            sum -= 0.15 * sum;
                        }
                    }
                    else if (type == "Business")
                    {
                        sum *= 15.60;
                        if (cnt >= 100)
                        {
                            sum -= 10 * 15.6;
                        }
                    }
                    else
                    {
                        sum *= 20;
                        if (cnt >= 10 && cnt <= 20)
                        {
                            sum -= 0.05 * sum;
                        }
                    }
                    break;
                case "Sunday":
                    if (type == "Students")
                    {
                        sum *= 10.46;
                        if (cnt >= 30)
                        {
                            sum -= 0.15 * sum;
                        }
                    }
                    else if (type == "Business")
                    {
                        sum *= 16;
                        if (cnt >= 100)
                        {
                            sum -= 10 * 16;
                        }
                    }
                    else
                    {
                        sum *= 22.5;
                        if (cnt >= 10 && cnt <= 20)
                        {
                            sum -= 0.05 * sum;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
