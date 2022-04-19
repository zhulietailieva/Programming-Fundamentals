using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (deck1.Count != 0 && deck2.Count != 0)
            {
                int card1 = deck1[0];
                int card2 = deck2[0];
                if (card1 > card2)
                {
                    deck1.Add(card1);
                    deck1.Add(card2);
                    deck2.Remove(card2);
                    deck1.Remove(card1);
                }
                else if (card2 > card1)
                {
                    deck2.Add(card2);
                    deck2.Add(card1);
                    deck1.Remove(card1);
                    deck2.Remove(card2);
                }
                else
                {
                    deck1.Remove(card1);
                    deck2.Remove(card2);
                }
                
            }
            if (deck1.Count == 0)
            {
                int sum = 0;
                for (int i = 0; i < deck2.Count; i++)
                {
                    sum += deck2[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < deck1.Count; i++)
                {
                    sum += deck1[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
