using System;

namespace RageExpenses1
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

            int trashedHeadset = gamesLost/2;
            int trashedMouse = gamesLost/3;
            int trashedKeybord = gamesLost/6;
            int trashedDisplay = gamesLost/12;

            double money = trashedHeadset * headsetPrice + trashedMouse * mousePrice + trashedKeybord * keybordPrice + trashedDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {money:f2} lv.");


        }
    }
}
