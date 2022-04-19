using System;
using System.Linq;

namespace TheLift1
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] currState = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < currState.Length; i++)
            {
                int wagon = currState[i];
                while (currState[i] < 4)
                {
                    people--;
                    currState[i]+=1;
                    if (people == 0)
                    {
                        break;
                    }
                }
                if (people == 0)
                {
                    break;
                }
            }

            if (people <= 0)
            {
                bool emptyseats = false;
                for (int i = 0; i < currState.Length; i++)
                {
                    if (currState[i] != 4)
                    {
                        emptyseats = true;
                    }
                }
                if (emptyseats)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(" ",currState));
                    return;
                }
                Console.WriteLine(string.Join(" ", currState));
                return;
            }
            Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            Console.WriteLine(string.Join(" ", currState));
        }
    }
}
