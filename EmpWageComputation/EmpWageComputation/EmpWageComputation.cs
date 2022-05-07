using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpWageComputation
    {
        public const int Is_Part_Time =1;
        public const int Is_Full_Time = 2;
        public const int Emp_Rate_Per_Hrs = 20;
        public const int Num_of_Working_Days = 20;
        public const int Max_Hrs_In_Mnth = 100;


        int EmpHrs;
        int TotalHrs = 0;
        int TotalWrkngDays = 0;
        
        Random random = new Random();
        public void EmpWageTillCond()
        {
            while (TotalHrs <= Max_Hrs_In_Mnth && TotalWrkngDays < Num_of_Working_Days)
            {
                TotalWrkngDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Full_Time:
                        Console.WriteLine("Day {0} Employee Works Full Time", TotalWrkngDays);
                        EmpHrs = 8;
                        break;
                    case Is_Part_Time:
                        Console.WriteLine("Day {0} Employee Works Full Time", TotalWrkngDays);
                        EmpHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Day {0} Employee is Absent ", TotalWrkngDays);
                        EmpHrs = 0;
                        break;
                }
                TotalHrs += EmpHrs;
                Console.WriteLine("Day {1} Employee Work Done {0} Hrs", EmpHrs, TotalWrkngDays);
            }
            int totalEmpWage = TotalHrs * Emp_Rate_Per_Hrs;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }
}
