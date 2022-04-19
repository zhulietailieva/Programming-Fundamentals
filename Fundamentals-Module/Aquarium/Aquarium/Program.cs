using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double per = double.Parse(Console.ReadLine());
            double v = (length * width * heigth)*0.001;
           
                Console.WriteLine( v*(1-per*0.01) );
        }
    }
}
