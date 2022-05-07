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

        int EmpHrs;
        int EmpWage=0;
        int MonthWage;
        
       Random random = new Random();


        public void EmpMonthWage()
        {
            for (int Day=0; Day <= Num_of_Working_Days; Day++)
            {
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case Is_Full_Time:
                        Console.WriteLine("Day {0} Employee Works Full Time",Day);
                        EmpHrs = 8;
                        break;
                    case Is_Part_Time:
                        Console.WriteLine("Day {0} Employee Works Full Time",Day);
                        EmpHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Day {0} Employee is Absent ",Day);
                        EmpHrs = 0;
                        break;
                }
                EmpWage = Emp_Rate_Per_Hrs * EmpHrs;
                MonthWage += EmpWage;
                Console.WriteLine("Employee Day {1} Wage: {0}", EmpWage,Day);
            }
            Console.WriteLine("Employee one Month Wage: {0}",MonthWage);
            
        }
       
        

    }
}
