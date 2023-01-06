using System;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int numKilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double priceTaxi = 0;
            double priceBus = 0.09 * numKilometers;
            double priceTrain = 0.06 * numKilometers;


            //Разстоянието е под 20 км  може да се ползва само такси. Началната такса е 0.70 лв. Понеже е през деня, тарифата е 0.79 лв. / км. С такси цената е: 0.70 + 5 * 0.79 = 4.65 лв.


            if (dayOrNight == "day" && numKilometers < 20)
            {
                priceTaxi = 0.70 + (numKilometers * 0.79);


               
                Console.WriteLine($"{0.70 + (numKilometers * 0.79):f2}");
            }
            else if (dayOrNight == "night" && numKilometers < 20)
            {
                priceTaxi = 0.70 + (numKilometers * 0.90);
                Console.WriteLine($"{0.70 + (numKilometers * 0.90):f2}");

            }



            if (numKilometers >= 20 && numKilometers < 100)
            {
                Console.WriteLine($"{numKilometers * 0.09:f2}");
            }
            if (numKilometers >= 100)
            {
                Console.WriteLine($"{numKilometers * 0.06:f2}");
            }

        }
    }
}
