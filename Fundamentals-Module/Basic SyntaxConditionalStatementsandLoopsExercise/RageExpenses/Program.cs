using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine()); 
            double mousePrice = double.Parse(Console.ReadLine());
            double keybordPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = 0;
            int trashedMouse = 0;
            int trashedKeybord = 0;
            int trashedDisplay = 0;
            for (int i = 0; i < gamesLost; i++)
            {
                if (i % 2 == 0&&i!=0)
                {
                    trashedHeadset++;
                }
                if (i % 3 == 0&&i!=0)
                {
                    trashedMouse++;
                }
                if (i % 6 == 0&&i!=0)
                {
                    trashedKeybord++;
                    if (trashedKeybord % 2 == 0)
                    {
                        trashedDisplay++;
                    }
                }
                
            }
            double sum = trashedHeadset * headsetPrice + trashedKeybord * keybordPrice + trashedMouse * mousePrice + trashedDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
            //ne raboti
        }
    }
}
