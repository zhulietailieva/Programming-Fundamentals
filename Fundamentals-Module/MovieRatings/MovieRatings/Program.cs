using System;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
           int filmsNum = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double rating = double.Parse(Console.ReadLine());
            string worstMovie = name;
            string  bestMovie = name;
            double lowestRating = rating;
            double highestRating = rating;
            double average = rating;
            for (int i = 0; i < filmsNum-1; i++)
            {
                 name = Console.ReadLine();
                 rating = double.Parse(Console.ReadLine());
                average += rating;
                if (rating < lowestRating) { worstMovie = name; lowestRating = rating; }
                if (rating > highestRating) { bestMovie = name; highestRating = rating; }
            }
            average = average / filmsNum;
            Console.WriteLine(bestMovie+" is with highest rating: "+string.Format("{0:F1}",highestRating));
            Console.WriteLine(worstMovie + " is with lowest rating: " + string.Format("{0:F1}", lowestRating));
            Console.WriteLine("Average rating: "+ string.Format("{0:F1}", average));
        }
    }
}
