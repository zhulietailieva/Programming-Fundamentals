using System;

namespace GameName
{
    class Program
    {
        static void Main(string[] args)
        {
                string name= Console.ReadLine();
                string winner = name;
                int points = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                if ((int)name.ToCharArray()[i] == number)
                {
                    points += 10;
                }
                else
                {
                    points += 2;
                }
                }
            int bestpoints = points;
                while (true)
                {
                   name = Console.ReadLine();
                   points = 0;
                    if (name == "Stop")
                    {
                        break;
                    }
                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if ((int)name.ToCharArray()[i] == number)
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }
                if (points >= bestpoints)
                {
                    bestpoints = points;
                    winner = name;
                }
                
                }
            /*  string i = "I";
              foreach (char c in i)
              {
  Console.WriteLine((int)c);*/
            Console.WriteLine($"The winner is {winner} with {bestpoints} points!");

            }
            
        }
    }

