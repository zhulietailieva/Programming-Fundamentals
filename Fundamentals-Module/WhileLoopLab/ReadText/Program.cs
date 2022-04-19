using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
         string line=       Console.ReadLine();
                if (line == "Stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
