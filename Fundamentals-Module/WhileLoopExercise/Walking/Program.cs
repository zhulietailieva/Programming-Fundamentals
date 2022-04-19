using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsTotal = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if(line=="Going home")
                {
                    int stepsHome = int.Parse(Console.ReadLine());
                    stepsTotal += stepsHome;
                    if (stepsTotal >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepsTotal - 10000} steps over the goal!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{10000-stepsTotal} more steps to reach goal.");
                        return;
                    }
                }
                int steps = int.Parse(line);
                stepsTotal += steps;
                if (stepsTotal >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsTotal-10000} steps over the goal!");
                    return;
                }

            }
        }
    }
}
