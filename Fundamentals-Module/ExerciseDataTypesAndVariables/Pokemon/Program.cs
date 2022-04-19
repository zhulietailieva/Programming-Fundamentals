using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int copyN = N;
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int pokedTargets = 0;
            while (N >= M)
            {
                N -=M;
                pokedTargets++;
                if (N == copyN / 2.0)
                {
                    if (Y != 0)
                    {
                        N = N / Y;
                  
                    }
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokedTargets);
        }
    }
}
