using System;

namespace FirstStepsInCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const double USDtoBGN = 1.79549;
            double usdollars = double.Parse(Console.ReadLine());
            Console.WriteLine(usdollars*USDtoBGN);
        }
    }
}
