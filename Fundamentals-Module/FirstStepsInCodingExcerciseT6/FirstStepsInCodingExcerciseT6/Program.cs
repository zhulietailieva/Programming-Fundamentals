using System;

namespace FirstStepsInCodingExcerciseT6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
           int workingHours = int.Parse(Console.ReadLine());
           double sum = (nylon + 2) * 1.5 + (paint +paint*0.10) * 14.5 + thinner * 5 + 0.4;
       double sumWorkers = (sum*0.3) * workingHours;       
            Console.WriteLine(sum+sumWorkers);
        }
    }
}
