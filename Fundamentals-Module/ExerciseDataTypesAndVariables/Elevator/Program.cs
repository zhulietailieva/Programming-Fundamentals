using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capasity = int.Parse(Console.ReadLine());
            int travels = 0;
          
            while (people > 0)
            {
               
                people -= capasity;
                travels++;

            }
            Console.WriteLine(travels);

        }
    }
}
