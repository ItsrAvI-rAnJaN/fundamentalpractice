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
       int EmpHrs;
        
       Random random = new Random();
        
       
        public void EmpWagePartorFull()
        {
            int EmpCheck = random.Next(0,3);
            switch (EmpCheck)
            {
                case Is_Full_Time:
                    Console.WriteLine("Full Time Employee");
                    EmpHrs = 8;
                    break;
                case Is_Part_Time:
                    Console.WriteLine("Part Time Employee");
                    EmpHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    EmpHrs = 0;
                    break;
            }
            int wage = Emp_Rate_Per_Hrs * EmpHrs;
            Console.WriteLine("Employee Daily Wage: {0}",wage);
        }
       
        

    }
}
