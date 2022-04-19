using System;

namespace basketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());
            double priceShoes = annualFee - 0.4 * annualFee;
            double priceClothes = priceShoes - 0.2 * priceShoes;
            double priceBall = 0.25 * priceClothes;
            double priceAccessories = 0.2 * priceBall;
            Console.WriteLine(annualFee+priceShoes+priceClothes+priceBall+priceAccessories);
        }
    }
}
