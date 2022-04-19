using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNAlength = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int bestSequenceIndex = DNAlength;
            int bestSequenceSum = 0;
            int longestSubsequence = 0;
            int[] bestSequence = new int[DNAlength];
            while(line!="Clone them!")
            {
                int[] sequence = line.Split("!").Select(int.Parse).ToArray();
                int sequenceSum = 0;
                for (int i = 0; i < DNAlength; i++)
                {
                    sequenceSum += sequence[i];
                }

                for (int i = 0; i < DNAlength; i++)
                {
                    
                    if (sequence[i] == 1)
                    {
                        int sequenceIndex = i;
                        int subsequence = 1;
                        
                        for (int j = i+1; j < DNAlength; j++)
                        {
                            if (sequence[i] != sequence[j])
                            {
                                break;
                            }
                            else
                            {
                                subsequence++;
                                
                            }
                        }
                        if (subsequence > longestSubsequence)
                        {
                            longestSubsequence = subsequence;
                            bestSequenceIndex = sequenceIndex;
                            bestSequenceSum = sequenceSum;
                            bestSequence = sequence;
                        }
                        else if (subsequence == longestSubsequence)
                        {
                            if (sequenceIndex < bestSequenceIndex)
                            {
                                longestSubsequence = subsequence;
                                bestSequenceIndex = sequenceIndex;
                                bestSequenceSum = sequenceSum;
                                bestSequence = sequence;
                            }
                            else if (sequenceIndex == bestSequenceIndex)
                            {
                                if (sequenceSum > bestSequenceSum)
                                {
                                    longestSubsequence = subsequence;
                                    bestSequenceIndex = sequenceIndex;
                                    bestSequenceSum = sequenceSum;
                                    bestSequence = sequence;
                                }
                            }
                        }
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex+1} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ",bestSequence));
        }
    }
}
//not working