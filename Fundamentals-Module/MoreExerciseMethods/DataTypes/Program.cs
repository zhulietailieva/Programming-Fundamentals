using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeofInput = Console.ReadLine();
            if (typeofInput == "int")
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(ReturnInt(n));
            }
            else if (typeofInput == "real")
            {
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ReturnDouble(n):f2}");
            }
            else{
                string s = Console.ReadLine();
                Console.WriteLine(ReturnString(s));
            }
        }
        static int ReturnInt(int n)
        {
            return n * 2;

        }
        static double ReturnDouble(double n)
        {
            return n*1.5;
        }
        static string ReturnString(string s)
        {
            return $"${s}$";
        }
    }
}
