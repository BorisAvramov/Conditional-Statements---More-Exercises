using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeededToProject = int.Parse(Console.ReadLine());
            int workDaysAtFirm = int.Parse(Console.ReadLine());
            int numOfworkersOvertime= int.Parse(Console.ReadLine());
            double netWorksDays = workDaysAtFirm - (workDaysAtFirm * 0.1);
            
            double workHours1 = netWorksDays * 8;
            double workHours2OverTime = workDaysAtFirm * numOfworkersOvertime * 2;
            double totalWorkHours = Math.Floor(workHours1 + workHours2OverTime);
            
            
            if (totalWorkHours >= hoursNeededToProject)
            {
                Console.WriteLine($"Yes!{totalWorkHours - hoursNeededToProject} hours left.");
            }
            else if (hoursNeededToProject > totalWorkHours)
            {
                Console.WriteLine($"Not enough time!{hoursNeededToProject - totalWorkHours} hours needed.");
            }
        }
    }
}
