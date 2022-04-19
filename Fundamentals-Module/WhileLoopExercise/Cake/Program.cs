using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int S = width * length;
            while (S > 0)
            {
                string line=Console.ReadLine();
                if (line == "STOP")
                {
                    Console.WriteLine($"{S} pieces are left.");
                    return;
                }
                S -= int.Parse(line);
            }
            Console.WriteLine($"No more cake left! You need {Math.Abs(S)} pieces more.");
        }
    }
}
