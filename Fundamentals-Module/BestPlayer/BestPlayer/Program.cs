
using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirstPlayer = Console.ReadLine();
            int goalsFirstPlayer = int.Parse(Console.ReadLine());
            string bestPlayer = nameFirstPlayer;
            int mostGoals = goalsFirstPlayer;
            Boolean hattrick = false;
            if (goalsFirstPlayer >= 3)
            {
                hattrick = true;
            }
            while (true)
            {
                string name = Console.ReadLine();
                    if (name == "END"){
                        Console.WriteLine($"{bestPlayer} is the best player!");
                        if (hattrick)
                        {
                            Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"He has scored {mostGoals} goals.");
                            break;
                        }
                        
                    }
                string goalss = Console.ReadLine();
                if (goalss == "END")
                {
                    Console.WriteLine($"{bestPlayer} is the best player!");
                    if (hattrick)
                    {
                        Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"He has scored {mostGoals} goals.");
                        break;
                    }
                }
                    int goals = int.Parse(goalss);
                    if (goals >= 10)
                    {
                        bestPlayer = name;
                        mostGoals = goals;
                        Console.WriteLine($"{bestPlayer} is the best player!");
                        Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
                        break;
                    }
                    if (goals >= 3)
                    {
                        hattrick = true;
                    }
                    if (goals > mostGoals)
                    {
                        mostGoals = goals;
                        bestPlayer = name;
                    }
                }
            }
        }
    }

