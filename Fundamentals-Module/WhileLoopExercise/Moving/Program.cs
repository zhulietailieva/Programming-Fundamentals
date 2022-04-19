using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int v = width * length * height;

            int spaceTaken = 0;
            while (spaceTaken < v)
            {
                string line = Console.ReadLine();
                if (line == "Done")
                {
                    Console.WriteLine($"{Math.Abs(spaceTaken-v)} Cubic meters left.");
                    return;
                }
                spaceTaken += int.Parse(line);                   
            }
            Console.WriteLine($"No more free space! You need {Math.Abs(spaceTaken - v)} Cubic meters more.");
        }
    }
}
