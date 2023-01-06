using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDaysInYear = int.Parse(Console.ReadLine());
            int workDaysInYear = 365 - restDaysInYear;

            int minutesToPlayRestDays = restDaysInYear * 127;
            int minutesToPlayWorkDays = workDaysInYear * 63;

            int totalMinutes = minutesToPlayRestDays + minutesToPlayWorkDays;
            int diffrence = Math.Abs(totalMinutes - 30000);
            // 113 ---- 227
            if (totalMinutes > 30000)
            {
                Console.WriteLine("Tom will run away");
                
                Console.WriteLine($"{diffrence/60} hours and {diffrence % 60} minutes more for play");
            }
            else if (totalMinutes < 30000)
            {
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{diffrence / 60} hours and {diffrence % 60} minutes less for play");
            }




           
        }
    }
}
