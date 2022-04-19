using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
                string site = Console.ReadLine();
                switch (site)
                {
                    case "Facebook":
                        salary -= 150;
                        if (salary <= 0)
                        {
                            Console.WriteLine("You have lost your salary.");
                            return;
                        }
                        break;
                    case "Instagram":
                        salary -= 100;
                        if (salary <= 0)
                        {
                            Console.WriteLine("You have lost your salary.");
                            return;
                        }
                        break;
                    case "Reddit":
                        salary -= 50;
                        if (salary <= 0)
                        {
                            Console.WriteLine("You have lost your salary.");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine(Math.Round(salary));
           
        }
    }
}
