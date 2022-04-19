using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           // double depositSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double per = double.Parse(Console.ReadLine());
            double sum = depositSum + months * ((depositSum * per) / 12);
           // Console.WriteLine(sum);

        }
    }
}
