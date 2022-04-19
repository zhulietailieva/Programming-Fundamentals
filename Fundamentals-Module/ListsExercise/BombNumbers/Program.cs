using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] bombNumAndPower = Console.ReadLine().Split();
            int bombNumber =int.Parse( bombNumAndPower[0]);
            int power = int.Parse(bombNumAndPower[1]);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    for (int j = 0; j < power; j++)
                    {
                        if (i - 1 > -1)
                        {
                            numbers.RemoveAt(i - 1);
                        }
                        if (i + 1 < numbers.Count)
                        {
                            numbers.RemoveAt(i + 1);
                        }
                    }
                    numbers.RemoveAt(i);
                    Console.WriteLine(string.Join(" ", numbers));
                }
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];

            }
            Console.WriteLine(string.Join(" ",numbers));
            Console.WriteLine(sum);
        }
    }
}
