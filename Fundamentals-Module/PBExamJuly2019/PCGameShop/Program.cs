using System;

namespace PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int gamesSold = int.Parse(Console.ReadLine());
            double gamesSold1 = gamesSold;
            int HearthstoneC = 0;
            int ForniteC = 0;
            int OverwatchC = 0;
            int othersC = 0;
            for (int i = 0; i < gamesSold; i++)
            {
                String gameName = Console.ReadLine();
                if(gameName== "Hearthstone")
                {
                    HearthstoneC++;
                }
              else  if (gameName == "Fornite")
                {
                    ForniteC++;
                }
             else   if (gameName == "Overwatch")
                {
                    OverwatchC++;
                }
                else
                {
                    othersC++;
                }
            }
            
            double perHS = (HearthstoneC * 100/ gamesSold1 );
           // perHS = Math.Round(perHS, 2);
            Console.WriteLine($"Hearthstone - {string.Format("{0:F2}", perHS)}%");

            double perFornite = (ForniteC * 100 / gamesSold1);
           // perFornite = Math.Round(perFornite, 2);
            Console.WriteLine($"Fornite - {string.Format("{0:F2}", perFornite)}%");

            double perOverWatch = (OverwatchC * 100 / gamesSold1);
           // perOverWatch = Math.Round(perOverWatch, 2);
            Console.WriteLine($"Overwatch - {string.Format("{0:F2}", perOverWatch)}%");

            double perOthers = (othersC * 100 / gamesSold1);
            //perOthers = Math.Round(perOthers, 2);
            Console.WriteLine($"Others - {string.Format("{0:F2}", perOthers)}%");
      
        }
    }
}
