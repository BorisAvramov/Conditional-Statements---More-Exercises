using System;

namespace Conditional_Statements___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int vloumeOfPoolInLiter = int.Parse(Console.ReadLine());
            int debitP1Hour = int.Parse(Console.ReadLine());
            int debitP2Hour = int.Parse(Console.ReadLine());
            double HourOfAbsence= double.Parse(Console.ReadLine());

            double fullP1 = debitP1Hour * HourOfAbsence;
            double fullP2 = debitP2Hour * HourOfAbsence;
            double totalFull = fullP1 + fullP2;
            double totalFullPercent = totalFull / vloumeOfPoolInLiter * 100;
            double fullP1Percent = fullP1 / totalFull * 100;
            double fullP2Percent = fullP2 / totalFull * 100;

            if (totalFull > vloumeOfPoolInLiter)
            {
                Console.WriteLine($"For {HourOfAbsence:f2} hours the pool overflows with {totalFull - vloumeOfPoolInLiter:f2} liters.");
            }
            else
            {
                Console.WriteLine($"The pool is {totalFullPercent:f2}% full. Pipe 1: {fullP1Percent:f2}%. Pipe 2: {fullP2Percent:f2}%.");
            }
        }
    }
}
