using System;

namespace Ronivation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int per = int.Parse(Console.ReadLine());

            double perToWorkWith = per * 0.01;
            double S = (height * width*4) - perToWorkWith * (height * width*4);
            S = Math.Ceiling(S);
            int sqMPainted = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Tired!")
                {
                    
                    Console.WriteLine($"{Math.Abs(S-sqMPainted)} quadratic m left.");
                    break;
                }
                else
                {
                    int mCovered = int.Parse(line);
                    sqMPainted += mCovered;
                    if (sqMPainted >= S)
                    {
                        if (sqMPainted > S)
                        {
                            Console.WriteLine($"All walls are painted and you have {Math.Abs(sqMPainted-S)} l paint left!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("All walls are painted! Great job, Pesho!");
                            break;
                        }
                    }

                }
            }

        }
    }
}
