using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int abc = int.Parse(Console.ReadLine());
            int a = abc % 10;
            int b = abc / 10 % 10;
            int c = abc / 100 % 10;
            for (int i = 1; i <= a; i++)
            {
                
                for (int j = 1; j <= b; j++)
                {
                    
                    for (int k = 1; k <=c ; k++)
                    {
                            Console.WriteLine(i+" * "+j+ " * " + k+" = "+i*j*k+";");
                    }
                }
            }
        }
    }
}
