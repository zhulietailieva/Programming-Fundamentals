using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqMeters = double.Parse(Console.ReadLine());
            double sum = sqMeters * 7.61;
            double discount = (18 * sum) / 100;
            Console.WriteLine($"The final price is: {sum-discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
