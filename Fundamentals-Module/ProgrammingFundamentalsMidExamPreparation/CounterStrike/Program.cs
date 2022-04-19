using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string line;
            int wonBattles = 0;
            while((line=Console.ReadLine())!="End of battle")
            {
                int distance = int.Parse(line);
                if (energy - distance < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;
                }
                energy -= distance;
                wonBattles++;
                if (wonBattles % 3 == 0)
                {
                    energy += wonBattles;
                }

            }
            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}
