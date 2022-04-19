using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int shotTargets = 0;
            string line = Console.ReadLine();
            while (line != "End")
            {
                int shot = int.Parse(line);
                if (shot < 0 || shot >= targets.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }
                else
                {
                    int shotTarget = targets[shot];
                    shotTargets++;
                    targets[shot] = -1;
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] > shotTarget)
                        {
                            targets[i] = (targets[i] - shotTarget);
                        }
                        else if (targets[i] != -1)
                        {
                            targets[i] = targets[i] + shotTarget;
                        }
                    }
                }

                line = Console.ReadLine();

            }
            Console.Write($"Shot targets: {shotTargets} -> ");
            Console.Write(string.Join(" ", targets));
        }
    }
}
//Shoot for the win e imeto na zadachata