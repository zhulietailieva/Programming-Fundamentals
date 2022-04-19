using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int studentsC = students;
            double lightsaberP = double.Parse(Console.ReadLine());
            double robeP = double.Parse(Console.ReadLine());
            double beltP = double.Parse(Console.ReadLine());
            double neededMoney=0;

            neededMoney += robeP * students;
            
            double MoneyForLightSabers = (Math.Ceiling(students + 0.1 * students)) * lightsaberP;
      
            neededMoney += MoneyForLightSabers;
            int freeBelts = 0;
            while (studentsC - 6 >= 0)
            {
                freeBelts++;
                studentsC -= 6;
            }
            double moneyForBelts = (students -freeBelts ) * beltP;
           
            neededMoney += moneyForBelts;
            if (neededMoney <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {String.Format("{0:F2}",Math.Abs(neededMoney))}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {String.Format("{0:F2}", Math.Abs(neededMoney - money))}lv more.");
            }
        }
    }
}
