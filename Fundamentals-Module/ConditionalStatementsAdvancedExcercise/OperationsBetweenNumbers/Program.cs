using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operation = Console.ReadLine()[0];
            int res;
            switch (operation)
              
            {//„+“, „-“, „*“, „/“, „%“
                case '+':
                     res = n1 + n2;
                    if(res%2==0) Console.WriteLine($"{n1} + {n2} = {res} - even");
                   else Console.WriteLine($"{n1} + {n2} = {res} - odd");
                    break;
                case '-':
                    res = n1 - n2;
                    if (res % 2 == 0) Console.WriteLine($"{n1} - {n2} = {res} - even");
                    else Console.WriteLine($"{n1} - {n2} = {res} - odd");
                    break;
                case '*':
                     res = n1 * n2;
                    if (res % 2 == 0) Console.WriteLine($"{n1} * {n2} = {res} - even");
                    else Console.WriteLine($"{n1} * {n2} = {res} - odd");
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                    double    res1 = n1*1.0 / n2*1.0;
                        Console.WriteLine($"{n1} / {n2} = {string.Format("{0:F2}", res1)}");
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        res = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = { res}");
                    }
                    break;
            }
        }
    }
}
