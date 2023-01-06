using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            int kgLeftFoodByMarina = int.Parse(Console.ReadLine());
            double foodForDogPerDayInKg = double.Parse(Console.ReadLine());
            double foodForCatPerDayInKg = double.Parse(Console.ReadLine());
            double foodForTurtlePerDayInGr = double.Parse(Console.ReadLine());

            double foodForTurtlePerDayInKg = foodForTurtlePerDayInGr / 1000;

            double foodNeededForAllAnimalsForAllDays = numOfDays * (foodForDogPerDayInKg + foodForCatPerDayInKg + foodForTurtlePerDayInKg);

            if (kgLeftFoodByMarina >= foodNeededForAllAnimalsForAllDays)
            {
                Console.WriteLine($"{Math.Floor(kgLeftFoodByMarina - foodNeededForAllAnimalsForAllDays)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeededForAllAnimalsForAllDays - kgLeftFoodByMarina)} more kilos of food are needed.");
            }
        }
    }
}