using System;

namespace Fixxxxxx
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJoinery = int.Parse(Console.ReadLine());
            string typeJoinery = Console.ReadLine();
            string delivery = Console.ReadLine();
            double sum = 0;
            if (numJoinery < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            switch (typeJoinery)
            {
                case "90X130":
                    sum = numJoinery * 110;
                    if (numJoinery > 30 && numJoinery <= 60) sum -= 5 * sum / 100;
                    if (numJoinery > 60) sum -= 8 * sum / 100;
                    break;
                case "100X150":
                    sum = numJoinery * 140;
                    if (numJoinery > 40 && numJoinery <= 80) sum -= 6 * sum / 100;
                    if (numJoinery > 80) sum -= 10 * sum / 100;
                    break;
                case "130X180":
                    sum = numJoinery * 190;
                    if (numJoinery > 20 && numJoinery <= 50) sum -= 7 * sum / 100;
                    if (numJoinery > 50) sum -= 12 * sum / 100;
                    break;
                case "200X300":
                    sum = numJoinery * 250;
                    if (numJoinery > 25 && numJoinery <= 50) sum -= 9 * sum / 100;
                    if (numJoinery > 50) sum -= 14 * sum / 100;
                    break;
                default:
                    break;
            }
            if (delivery == "With delivery") sum += 60;
            if (numJoinery > 99) sum = sum - (4 * sum )/ 100;
            Console.WriteLine(string.Format("{0:F2}", sum)+" BGN");
        }
    }
}
