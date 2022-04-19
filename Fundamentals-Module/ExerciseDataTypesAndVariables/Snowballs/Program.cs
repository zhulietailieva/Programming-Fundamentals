using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger maxValue = BigInteger.Zero;
            string res = "";
            for (int i = 0; i < N; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow ((snow / (time )) , quality);
                if (value > maxValue)
                {
                    maxValue = value;
                    res = ($"{snow} : {time} = {value} ({quality})");
                }
            }
            Console.WriteLine(res);
        }
    }
}
