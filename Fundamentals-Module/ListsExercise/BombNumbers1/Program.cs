using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] bombNumberAndPower = Console.ReadLine().Split().ToArray();
            int bombNum = int.Parse(bombNumberAndPower[0]);
            int power = int.Parse(bombNumberAndPower[1]);
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNum)
                {
                   
                    for (int j = 0; j < power; j++)
                    {

                        if (i - (1+j) > -1)
                        {
                            numbers.RemoveAt(i -( 1+j));
                        }
                       
                    }
               i=     numbers.IndexOf(bombNum);
                    for (int j = 0; j < power; j++)
                    {
                        if (i + (1 ) < numbers.Count)
                        {
                            numbers.RemoveAt(i + (1 ));
                        }
                    }
                    numbers.RemoveAt(i);
                }
            }
            
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
