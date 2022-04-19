using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGroups = int.Parse(Console.ReadLine());
            int totalPeople = 0;
            double musalaP = 0;
            double monblanP = 0;
            double kilimandzharoP = 0;
            double k2P = 0;
            double everestP = 0;

            for (int i = 0; i < numGroups; i++)
            {
                int numPeople = int.Parse(Console.ReadLine());
                totalPeople += numPeople;
                if (numPeople < 6)
                {
                    musalaP += numPeople;
                }
                else if (numPeople < 13)
                {
                    monblanP += numPeople;
                }
                else if (numPeople < 26)
                {
                    kilimandzharoP += numPeople;
                }
                else if (numPeople < 41)
                {
                    k2P += numPeople;
                }
                else
                {
                    everestP += numPeople;
                }

            }
            Console.WriteLine(string.Format("{0:F2}",musalaP/totalPeople*100)+"%");
            Console.WriteLine(string.Format("{0:F2}", monblanP / totalPeople * 100) + "%");
            Console.WriteLine(string.Format("{0:F2}", kilimandzharoP / totalPeople * 100) + "%");
            Console.WriteLine(string.Format("{0:F2}", k2P / totalPeople * 100) + "%");
            Console.WriteLine(string.Format("{0:F2}", everestP / totalPeople * 100) + "%");
        }
    }
}
