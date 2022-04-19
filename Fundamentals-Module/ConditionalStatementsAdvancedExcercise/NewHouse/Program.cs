using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0;
            switch (flowers)
            {//"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
                case "Roses":
                    sum = num * 5;
                    if (num > 80) sum -= 0.1*sum;
                    break;
                case "Dahlias":
                    sum = num * 3.8;
                    if (num > 90) sum -= 0.15 * sum;
                    break;
                case "Tulips":
                    sum = num * 2.8;
                    if (num > 80) sum -= 0.15 * sum;
                    break;
                case "Narcissus":
                    sum = num * 3;
                    if (num < 120) sum += 0.15 * sum;
                    break;
                case "Gladiolus":
                    sum = num * 2.5;
                    if (num < 80) sum += 0.2 * sum;
                    break;
            }
            if (budget < sum)
            {
                Console.WriteLine($"Not enough money, you need {string.Format("{0:F2}",Math.Abs(budget-sum))} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {num} {flowers} and {string.Format("{0:F2}", Math.Abs(budget - sum))} leva left.");
            }
        }
    }
}
