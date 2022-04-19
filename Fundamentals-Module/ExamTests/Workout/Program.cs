using System;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingDays = int.Parse(Console.ReadLine());
            double kmFirstDay = double.Parse(Console.ReadLine());
            double kmLastDay = kmFirstDay;
            double kmTotal = kmFirstDay;
            for (int i = 0; i < trainingDays; i++)
            {
                int per = int.Parse(Console.ReadLine());
                kmLastDay += kmLastDay * (0.01 * per);
                kmTotal += kmLastDay;
            }
            if (kmTotal >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(Math.Abs(kmTotal-1000))} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(Math.Abs(kmTotal - 1000))} more kilometers");
            }
        }
    }
}
