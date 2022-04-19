using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string res = "";
            for (int i = 0; i < n; i++)
            {
                char letter = Console.ReadLine().ToCharArray()[0];
                int outputInt = (letter + 0 + key);
                char letterOutput = (char)outputInt;
                res += letterOutput + "";
            }
            Console.WriteLine(res);
        }
    }
}
