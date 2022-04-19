using System;

namespace PBExamTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int a = M % 10;
            int b = M / 10 % 10;
            int c = M / 100 % 10;
            int d = M / 1000 % 10;
            int a1 = N % 10;
            int b1= N / 10 % 10;
            int c1= N / 100 % 10;
            int d1 = N / 1000 % 10;

            for (int i = M; i < N; i++)
            {
                if ((i % 10) % 2 != 0)
                {
                    if (i % 10 >= a && i % 10 <= a1)
                    {
                        if ((i/10 % 10) % 2 != 0)
                        {
                            if (i/10 % 10 >= b && i/10 % 10 <= b1)
                            {
                                if ((i/100 % 10) % 2 != 0)
                                {
                                    if (i/100 % 10 >= c && i/100 % 10 <= c1)
                                    {
                                        if ((i/1000 % 10) % 2 != 0)
                                        {
                                            if (i/1000 % 10 >= d && i/1000 % 10 <= d1)
                                            {
                                                Console.Write(i + " ");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                
          
            }
            
        }
    }
}
