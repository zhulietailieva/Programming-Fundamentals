using System;

namespace PBExamTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double points=0;
            int rbp = 0;int obp = 0;int ybp = 0;int wbp = 0;
            int otherColorsPicked = 0;
            int blackPDivides = 0;

            for (int i = 0; i < N; i++)
            {
                string color = Console.ReadLine();
                if (color == "red") { rbp++;points += 5; }
                else if(color == "orange") { obp++; points += 10; }
                else if (color == "yellow") { ybp++; points += 15; }
                else if (color == "white") { wbp++; points += 20; }
                else if (color == "black") { blackPDivides++;double pointss=Math.Floor( points/2); points = pointss; }
                else { otherColorsPicked++; }
            }
            Console.WriteLine("Total points: "+points );
            Console.WriteLine("Points from red balls: " + rbp);
            Console.WriteLine("Points from orange balls: " + obp);
            Console.WriteLine("Points from yellow balls: " + ybp);
            Console.WriteLine("Points from white balls: " + wbp);
            Console.WriteLine("Other colors picked: " + otherColorsPicked);
            Console.WriteLine("Divides from black balls: " + blackPDivides);
        }

    }
}
