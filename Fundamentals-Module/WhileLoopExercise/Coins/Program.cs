using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            const double lev2 = 2;
            const double lev = 1.0;
            const double st50 = 0.5;
            const double st20 = 0.2;
            const double st10 = 0.1;
            const double st5 = 0.05;
            const double st2 = 0.02;
            const double st1 = 0.01;
            int numCoins = 0;
            
            double money = double.Parse(Console.ReadLine());
            while (money > 0)
            {
                if (money - lev2>=0)
                {
                    numCoins++;
                    money-=  lev2;
              money=      Math.Round(money, 2);
                }
             else   if (money - lev >= 0)
                {
                    numCoins++;
                    money -= lev;
                    money = Math.Round(money, 2);
                }
                else if (money - st50 >= 0)
                {
                    numCoins++;
                    money -= st50;
                    money = Math.Round(money, 2);
                }
                else if (money - st20 >= 0)
                {
                    numCoins++;
                    money -= st20;
                    money = Math.Round(money, 2);
                }
                else if (money - st10 >= 0)
                {
                    numCoins++;
                    money -= st10;
                    money = Math.Round(money, 2);
                }
                else if (money - st5 >= 0)
                {
                    numCoins++;
                    money -= st5;
                    money = Math.Round(money, 2);
                    
                }
                else if (money - st2 >= 0)
                {
                    numCoins++;
                    money -= st2;
                    money = Math.Round(money, 2);
                }
                else
                {
                    numCoins++;
                    money -= st1;
                    money = Math.Round(money, 2);
                }

            }
            Console.WriteLine(numCoins);
        }
    }
}
