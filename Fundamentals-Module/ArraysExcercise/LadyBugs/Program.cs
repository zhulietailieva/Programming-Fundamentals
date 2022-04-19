using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] startingPoint = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < startingPoint.Length; i++)
            {
                if (startingPoint[i] < fieldSize && startingPoint[i] > -1)
                {
                    field[startingPoint[i]] = 1;
                }
               
            }
            
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] fly = line.Split();
                int indexLadybug = int.Parse(fly[0]);
                string direction = fly[1];
                int moves = int.Parse(fly[2]);
                if (indexLadybug > -1 && indexLadybug < fieldSize)
                {
                    if (field[indexLadybug] != 0 )
                    {

                        if (direction == "left")
                        {
                            if (indexLadybug - moves < 0)
                            {
                            field[indexLadybug]     = 0;
                            }
                            else
                            {
                            while (field[indexLadybug - moves] != 0)
                            { moves+=moves;
                                if (indexLadybug - moves < 0)
                                {
                                    break;
                                }
                            }
                            field[indexLadybug] = 0;
                            if (indexLadybug - moves >= 0)
                            {
                                field[indexLadybug - moves] = 1;

                            }
                            }
                            

                        }
                        if (direction == "right")
                        {
                            if (indexLadybug + moves >= fieldSize)
                            {
                                field[indexLadybug] = 0;
                            }
                            else
                            {
                            while (field[indexLadybug + moves] != 0)
                            {
                                moves+=moves;
                                if (indexLadybug + moves >= fieldSize)
                                {
                                    break;
                                }
                            }
                            field[indexLadybug] = 0;
                            if (indexLadybug + moves < fieldSize)
                            {
                                field[indexLadybug + moves] = 1;

                            }
                            }                           
                        }
                    }
                }
                
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
