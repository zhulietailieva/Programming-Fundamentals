using System;

namespace PBExamMarch2020T4
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double totalfoodEaten = 0;
            int totalDogfoodEaten = 0;
            int totalCatfoodEaten = 0;
            double totalBiscuits = 0.0;
            for (int i = 1; i <= days; i++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());
                totalfoodEaten += dogFood + catFood;
                totalDogfoodEaten += dogFood;
                totalCatfoodEaten += catFood;
                if (i % 3 == 0)
                {
                    totalBiscuits += Math.Ceiling((10 * (Convert.ToDouble(dogFood) + Convert.ToDouble(catFood)) / 100));            
                }
            }
            double foodEatenPer = (totalfoodEaten * 100) / food;
            double dogFoodEatenPer = (totalDogfoodEaten * 100) / totalfoodEaten;
            double catFoodEatenPer = (totalCatfoodEaten * 100) / totalfoodEaten;
            Console.WriteLine($"Total eaten biscuits: {totalBiscuits}gr.");

            Console.WriteLine(string.Format("{0:F2}", foodEatenPer) + "% of the food has been eaten.");
            Console.WriteLine(string.Format("{0:F2}", dogFoodEatenPer) + "% eaten from the dog.");
            Console.WriteLine(string.Format("{0:F2}", catFoodEatenPer) + "% eaten from the cat.");
        }
    }
}