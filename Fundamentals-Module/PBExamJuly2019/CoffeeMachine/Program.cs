using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numDrinks = int.Parse(Console.ReadLine());
            double sum = 0;

            if (drink == "Espresso")
            {
                if (sugar == "Without")
                {
                    sum = numDrinks * 0.9;
                    sum = 0.65 * sum;
                    
                }
                else if (sugar == "Normal")
                {
                    sum = numDrinks * 1;
                }
                else
                {
                    sum = numDrinks * 1.2;
                }
                if (numDrinks >= 5)
                {
                    sum -= 0.25 * sum;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    sum = numDrinks * 1;
                    sum = 0.65 * sum;

                }
                else if (sugar == "Normal")
                {
                    sum = numDrinks * 1.2;
                }
                else
                {
                    sum = numDrinks * 1.6;
                }
            }
            else
            {
                if (sugar == "Without")
                {
                    sum = numDrinks * 0.5;
                    sum = 0.65 * sum;

                }
                else if (sugar == "Normal")
                {
                    sum = numDrinks * 0.6;
                }
                else
                {
                    sum = numDrinks * 0.7;
                }
            }
            if (sum > 15)
            {
                sum -= 0.2 * sum;
            }
            Console.WriteLine($"You bought {numDrinks} cups of {drink} for {string.Format("{0:F2}",sum)} lv.");
        }
    }
}
