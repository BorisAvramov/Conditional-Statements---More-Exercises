using System;

namespace Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfFule = Console.ReadLine();
            double literFuelInTank = double.Parse(Console.ReadLine());

            if (kindOfFule == "Diesel" || kindOfFule == "Gasoline" || kindOfFule == "Gas")
            {
                if (literFuelInTank >= 25)
                {
                    Console.WriteLine($"You have enough {kindOfFule.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {kindOfFule.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine($"Invalid fuel!");
            }
        }
    }
}
