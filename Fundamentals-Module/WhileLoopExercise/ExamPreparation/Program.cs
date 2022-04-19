using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFails = int.Parse(Console.ReadLine());
            int fails = 0;
            int numProblems = 0;
            double average = 0;
            string lastProblem = "";
            
            while (true)
            {   string task = Console.ReadLine();
              if(  task == "Enough"|| fails >= numFails)
                {
                    if (task == "Enough")
                    {
                        Console.WriteLine($"Average score: {string.Format("{0:F2}",(average/(numProblems*1.0)))}");
                        Console.WriteLine($"Number of problems: {numProblems}");
                        Console.WriteLine($"Last problem: {lastProblem}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You need a break, {fails} poor grades.");
                        return;
                    }
                }
                numProblems++;
                int grade = int.Parse(Console.ReadLine());
                average += grade;
                if (grade <= 4)
                {
                    fails++;
                    if (fails >= numFails)
                    {
                        Console.WriteLine($"You need a break, {fails} poor grades.");
                        return;
                    }
                }
                lastProblem = task;
               
            }
        }
    }
}
