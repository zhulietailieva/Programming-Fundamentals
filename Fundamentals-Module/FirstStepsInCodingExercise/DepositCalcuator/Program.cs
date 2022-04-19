using System;

namespace DepositCalcuator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double per = double.Parse(Console.ReadLine());
            double sum = depSum + months * ((depSum * per) / 12);
            Console.WriteLine(sum);
        }
    }
}
