using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal max = decimal.MinValue;
            string biggest = "";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal V = (decimal)Math.PI * radius * radius * height;
                if (V > max)
                {
                    max = V;
                    biggest = model;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
