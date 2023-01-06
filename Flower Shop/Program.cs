using System;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceMagnolia = 3.25;
            double priceZumbul = 4;
            double priceRoses = 3.50;
            double priceCactus = 8;

            int numOfMagnoliq = int.Parse(Console.ReadLine());
            int numOfZumbul = int.Parse(Console.ReadLine());
            int numOfRoses = int.Parse(Console.ReadLine());
            int numOfCactus = int.Parse(Console.ReadLine());

            double priceOfGift = double.Parse(Console.ReadLine());

            double priceOfOrder = numOfMagnoliq * priceMagnolia + numOfZumbul * priceZumbul + numOfRoses * priceRoses + numOfCactus * priceCactus;
            double priceOfOrderAfterTax = priceOfOrder - (priceOfOrder * 0.05);
            if (priceOfOrderAfterTax >= priceOfGift)
            {
                Console.WriteLine($"She is left with {Math.Floor(priceOfOrderAfterTax - priceOfGift)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Mathe.Ceiling(priceOfGift - priceOfOrderAfterTax)} leva.");
            }

        }
    }
}
