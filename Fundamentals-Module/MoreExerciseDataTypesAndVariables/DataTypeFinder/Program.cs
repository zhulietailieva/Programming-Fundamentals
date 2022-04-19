using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line.ToString() != "END")
            {
                int a;
                float b;
                char c;
                bool d;
                if (int.TryParse(line,out a))
                {
                    Console.WriteLine($"{line} is integer type");
                }
                else if(float.TryParse(line,out b))
                {
                    Console.WriteLine($"{line} is floating point type");
                }
                else if (char.TryParse(line, out c))
                {
                    Console.WriteLine($"{line} is character type");
                }
                else if (bool.TryParse(line, out d))
                {
                    Console.WriteLine($"{line} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{line} is string type");
                }


                line = Console.ReadLine();


            }
        }
    }
}
