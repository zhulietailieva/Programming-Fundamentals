using System;
using System.Numerics;

namespace FromLeftТoТheRight
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < N; i++)
            {
                BigInteger sum = 0;
                string line = Console.ReadLine();
                int space = 0;
                 space = line.IndexOf(" ");
                
                 string s1 = line.Substring(0, space);
                string s2 = "";
                for (int j = space+1; j < line.Length ; j++)
                {
                    s2 += line.ToCharArray()[j];
                }
                BigInteger n1 = BigInteger.Parse(s1);
                BigInteger n2 = BigInteger.Parse(s2);
                
                if (n1 > n2)
                {
                    if (n1 < 0)
                    {
                        n1 = (BigInteger)Math.Abs((decimal)n1);
                    }
                    while (n1 > 0)
                    {
                        
                        sum += n1 % 10;
                        n1 /= 10;
                    }
                }
                else
                {
                    if (n2 < 0)
                    {
                        n2 = (BigInteger)Math.Abs((decimal)n2);
                    }
                    while (n2 > 0)
                    {
                        sum += n2 % 10;
                        n2 /= 10;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
