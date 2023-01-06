using System;

namespace Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfFuel = Console.ReadLine();
            double quantityOfFuel = double.Parse(Console.ReadLine());
            string clubCart = Console.ReadLine();

            double priceGasolinLiter = 2.22;
            double priceDieselLiter = 2.33;
            double priceGasLiter = 0.93;


            if (clubCart == "Yes")
            {
                priceGasolinLiter = priceGasolinLiter - 0.18;
                priceDieselLiter = priceDieselLiter - 0.12;
                priceGasLiter = priceGasLiter - 0.08;

            }

            if (kindOfFuel == "Gasoline")
            {
                double totalPriceOfFuel = quantityOfFuel * priceGasolinLiter;


                if (quantityOfFuel >= 20 && quantityOfFuel <= 25)
                {
                    totalPriceOfFuel = totalPriceOfFuel - totalPriceOfFuel * 0.08;
                    Console.WriteLine($"{totalPriceOfFuel:f2} lv.");

                }
                else if (quantityOfFuel > 25)
                {
                    totalPriceOfFuel = totalPriceOfFuel - totalPriceOfFuel * 0.1;
                    Console.WriteLine($"{totalPriceOfFuel:f2} lv.");

                }
                else
                {
                    Console.WriteLine($"{totalPriceOfFuel:f2} lv.");
                }

            }
            if (kindOfFuel == "Diesel")
            {
                double totalPriceOfFuel = quantityOfFuel * priceDieselLiter;

                if (quantityOfFuel >= 20 && quantityOfFuel <= 25)
                {
                    totalPriceOfFuel = totalPriceOfFuel - totalPriceOfFuel * 0.08;
                    Console.WriteLine($"{totalPriceOfFuel:f2} lv.");

                }
                else if (quantityOfFuel > 25)
                {
                    totalPriceOfFuel = totalPriceOfFuel - totalPriceOfFuel * 0.1;
                    Console.WriteLine($"{totalPriceOfFuel:f2} lv.");

                }
                else
                {
                    Console.WriteLine($"{totalPriceOfFuel:f2} lv.");
                }
            }
            if (kindOfFuel == "Gas")
            {
                double totalPriceOfFuel = quantityOfFuel * priceGasLiter;

                if (quantityOfFuel >= 20 && quantityOfFuel <= 25)
                {
                    totalPriceOfFuel = totalPriceOfFuel - totalPriceOfFuel * 0.08;
                    Console.WriteLine($"{totalPriceOfFuel:f2} lv.");

                }
                else if (quantityOfFuel > 25)
                {
                    totalPriceOfFuel = totalPriceOfFuel - totalPriceOfFuel * 0.1;
                    Console.WriteLine($"{totalPriceOfFuel:f2} lv.");

                }
                else
                {
                    Console.WriteLine($"{totalPriceOfFuel:f2} lv.");
                }
            }

        }
    }
}
