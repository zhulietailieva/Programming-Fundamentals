using System;
using System.Linq;

namespace MaxSequenceОfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sequence = 0;
            int maxNumbersInARow = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int numbersInARow = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    
                    if (arr[i] != arr[j])
                    {
                        break;
                    }
                    else
                    {
                        numbersInARow++;
                        if (numbersInARow > maxNumbersInARow)
                        {
                            maxNumbersInARow = numbersInARow;
                            sequence = arr[j];
                        }
                    }
                }
            }
            string res = "";
            while (maxNumbersInARow > 0)
            {
                res += sequence + " ";
                maxNumbersInARow--;
            }
            Console.WriteLine(res);
        }
    }
}
