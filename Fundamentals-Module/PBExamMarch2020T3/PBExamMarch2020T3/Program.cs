using System;

namespace PBExamMarch2020T3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double sum = 0; ;
            if (fruit == "Watermelon")
            {
                if (size == "big") sum = 5 * 28.70 * num;
                else sum = 2 * 56 * num;
               
            }
            if (fruit == "Mango")
            {
                if (size == "big") sum = 5 * 19.60 * num;
                else sum = 2 * 36.66 * num;

            }
            if (fruit == "Pineapple")
            {
                if (size == "big") sum = 5 * 24.80 * num;
                else sum = 2 * 42.10 * num;

            }
            if (fruit == "Raspberry")
            {
                if (size == "big") sum = 5 * 15.20 * num;
                else sum = 2 * 20 * num;

            }
            if (sum >= 400 && sum <= 1000) sum = sum - (15 * sum) / 100;
            if(sum>1000) sum = sum - (50 * sum) / 100;
            Console.WriteLine(string.Format("{0:F2}", sum) + " lv.");
        }
    }
}
