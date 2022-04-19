using System;

namespace CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
           
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal flourPrice= decimal.Parse(Console.ReadLine());
            decimal singleEggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            int packagesOfFlour = students - students / 5;
            decimal moneyForFlour = packagesOfFlour * flourPrice;

            int neededAprons = (int)(students + Math.Ceiling(0.2 * students));
            decimal moneyForAprons = neededAprons * apronPrice;

            int neededEggs = 10 * students;
            decimal moneyForEggs = neededEggs * singleEggPrice;

            decimal neededMoney = moneyForFlour + moneyForAprons + moneyForEggs;

           
            if (neededMoney <= budget)
            {
                Console.WriteLine($"Items purchased for {Math.Abs(neededMoney):f2}$.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(neededMoney - budget):f2}$ more needed.");
            }
        }
    }
}
