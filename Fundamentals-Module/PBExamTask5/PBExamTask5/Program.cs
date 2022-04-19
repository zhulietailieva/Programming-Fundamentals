using System;

namespace PBExamTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int goals = int.Parse(Console.ReadLine());
            string bestPlayer = name;
            int mostGoals = goals;
            bool hattrick = false;
            
            if (goals >= 10)
            {
                Console.WriteLine($"{name} is the best player!");
                Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
            }
            while (true)
            {
                if (goals <= 0 ) return;
                name = Console.ReadLine();
                if (name == "END") break;
                goals = int.Parse(Console.ReadLine());
                if (goals >= 10) 
                {
                    mostGoals = goals; hattrick = true;bestPlayer = name;
                    break; 
                }
                if (goals >= 3) hattrick = true;
                if (goals > mostGoals)
                {
                    mostGoals = goals;bestPlayer = name;
                }
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (hattrick)
            {
                Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
            }
            else 
            {
                Console.WriteLine($"He has scored {mostGoals} goals.");
            }
        }
    }
}
