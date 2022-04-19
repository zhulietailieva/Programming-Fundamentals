using System;

namespace FirstStepsInCodingExcerciseT5
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters= int.Parse(Console.ReadLine());
            int per = int.Parse(Console.ReadLine());
            double sum = pens * 5.80 + markers * 7.20 + liters * 1.20;
            Console.WriteLine(sum-per*sum/100);
        }
    }
}
