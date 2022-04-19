using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int totalSeats = cols * rows;
            double sum = 0;
            switch (type)
            {
                case "Premiere":
                    sum = totalSeats * 12;
                    Console.WriteLine(string.Format("{0:F2}",sum)+" leva");
                    break;
                case "Normal":
                    sum = totalSeats * 7.5;
                    Console.WriteLine(string.Format("{0:F2}", sum) + " leva");
                    break;
                case "Discount":
                    sum = totalSeats * 5;
                    Console.WriteLine(string.Format("{0:F2}", sum) + " leva");
                    break;
            }
        }
    }
}
