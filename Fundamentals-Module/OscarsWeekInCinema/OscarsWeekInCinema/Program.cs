using System;

namespace OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string hall = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double sum = 0;
            if(name== "A Star Is Born")
            {
                if (hall == "normal") sum = tickets * 7.5;
               else if (hall == "luxury") sum = tickets * 10.5;
                else sum = tickets * 13.5;
            }
            if (name == "Bohemian Rhapsody")
            {
                if (hall == "normal") sum = tickets * 7.35;
                else if (hall == "luxury") sum = tickets * 9.45;
                else sum = tickets * 12.75;
            }
            if (name == "Green Book")
            {
                if (hall == "normal") sum = tickets * 8.15;
                else if (hall == "luxury") sum = tickets * 10.25;
                else sum = tickets * 13.25;
            }
            if (name == "The Favourite")
            {
                if (hall == "normal") sum = tickets * 8.75;
                else if (hall == "luxury") sum = tickets * 11.55;
                else sum = tickets * 13.95;
            }

            Console.WriteLine(name+" -> "+string.Format("{0:F2}",sum)+" lv.");
        }
    }
}
