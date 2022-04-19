using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s.ToCharArray()[i]=='a')
                {
                    sum += 1;
                }
                if (s.ToCharArray()[i] == 'e')
                {
                    sum += 2;
                }
                if (s.ToCharArray()[i] == 'i')
                {
                    sum += 3;
                }
                if (s.ToCharArray()[i] == 'o')
                {
                    sum += 4;
                }
                if (s.ToCharArray()[i] == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
