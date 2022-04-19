using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            switch (action)
            {
                case "add":
                    Console.WriteLine(addNumbers(a,b)); break;
                case "multiply":
                    Console.WriteLine(multiplyNumbers(a, b)); break;
                case "substract":
                    Console.WriteLine(substractNumbers(a, b)); break;
                case "divide":
                    Console.WriteLine(divideNumbers(a, b)); break;
            }


        }
        static double addNumbers(double a,double b)
        {
            return a + b;

        } 
      static  double multiplyNumbers(double a,double b)
        {
            return a * b;
        }
     static   double divideNumbers(double a,double b)
        {
            return a / b;


        }
     static   double substractNumbers(double a,double b)
        {
            return a - b;
        }
    }
}
