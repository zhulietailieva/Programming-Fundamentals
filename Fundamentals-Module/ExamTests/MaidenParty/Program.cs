using System;

namespace MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double maidenPartyPrice = double.Parse(Console.ReadLine());
            int loveLetters = int.Parse(Console.ReadLine());
            int roses= int.Parse(Console.ReadLine());
            int keychains = int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int surprises = int.Parse(Console.ReadLine());
            
            int numArticules = loveLetters + roses + keychains + caricatures + surprises;
            double neededSum = loveLetters * 0.6 + roses * 7.2 + keychains * 3.6 + caricatures * 18.2 + surprises * 22;
           

            if (numArticules >= 25)
            {
                neededSum -= 0.35 * neededSum;
            }
           
            neededSum -= 0.1 * neededSum;
            
          
            if (neededSum <= maidenPartyPrice)
            {
                Console.WriteLine($"Not enough money! {string.Format("{0:F2}", Math.Abs(maidenPartyPrice - neededSum))} lv needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {string.Format("{0:F2}",Math.Abs(maidenPartyPrice-neededSum))} lv left.");
                
            }
        }
    }
}
