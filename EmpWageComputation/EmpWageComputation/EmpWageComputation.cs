using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpWageComputation
    {
         const int Is_Part_Time =1;
         const int Is_Full_Time = 2;        // taking constant Variable 
         const int Emp_Rate_Per_Hrs = 20;     
         const int Num_of_Working_Days = 20;
         const int Max_Hrs_In_Mnth = 100;


        int EmpHrs;
        int TotalHrs = 0;                    // Taking instance Variable to store  hrs & working days
        int TotalWrkngDays = 0;   
        
        // creaating instnce/object of Random Class
        Random random = new Random();
        public void CalcEmpWage()
        {
            while (TotalHrs <= Max_Hrs_In_Mnth && TotalWrkngDays < Num_of_Working_Days)
            {
                TotalWrkngDays++;
                // using random to genrate 0,1,2 & storing in variable EmpCheck
                int empCheck = random.Next(0, 3);

                // using Switch to Check Empcheck & get workin Hrs..
                switch (empCheck)
                {
                    case Is_Full_Time:
                        
                        EmpHrs = 8;
                        break;
                    case Is_Part_Time:
                        EmpHrs = 4;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                TotalHrs += EmpHrs;
                Console.WriteLine(" In Day {1} Employee Work Done is {0} Hrs", EmpHrs, TotalWrkngDays);

                // using if Block to Print if reached Condition Working hrs & Working Days in a Month
                if (TotalHrs == Max_Hrs_In_Mnth)
                {
                    Console.WriteLine("Total Working Hours in a Month has reached = " + Max_Hrs_In_Mnth + " hrs");
                }
                if (TotalWrkngDays == Num_of_Working_Days)
                {
                    Console.WriteLine("Total Working Days in a Month  has reached = " + Num_of_Working_Days + " days");
                }
            }
            // printing Total Wages Of Employee
            int totalEmpWage = TotalHrs * Emp_Rate_Per_Hrs;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }
}
