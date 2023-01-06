using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaVineyard = int.Parse(Console.ReadLine());
            double kgGrapeFromOneQMeter = double.Parse(Console.ReadLine());
            int literWineNeeded = int.Parse(Console.ReadLine());
            int numOfWorkers = int.Parse(Console.ReadLine());

            double totalKgGrape = areaVineyard * kgGrapeFromOneQMeter;
            double kgGrapeForWine = totalKgGrape * 0.4;
            double NumOfLiterWine = kgGrapeForWine / 2.5;

            if (NumOfLiterWine >= literWineNeeded)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(NumOfLiterWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(NumOfLiterWine - literWineNeeded)} liters left -> {Math.Ceiling((NumOfLiterWine - literWineNeeded) / numOfWorkers)} liters per person.");
            }
            else if (NumOfLiterWine < literWineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(literWineNeeded - NumOfLiterWine)} liters wine needed.");
            }

        }
    }
}
