using System;

namespace PBExamMarch2020T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double uan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
            int bitcointToLv = bitcoin * 1168;
            double uanToDollar = uan * 0.15;
            double DollartoLv = uanToDollar * 1.76;
            double totalLv = DollartoLv + bitcointToLv;
            double euro = totalLv / 1.95;
            double res = euro - (commission * euro) / 100;
            Console.WriteLine(string.Format("{0:F2}", res));
        }
    }
}
