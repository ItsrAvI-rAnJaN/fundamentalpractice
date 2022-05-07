using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpWageComputation
    {
        int Is_Present =1;
        int Emp_Rate_Per_Hrs = 20;
        int EmpHrs;
        
        Random random = new Random();
        
       
        public void EmpDailyWage()
        {
            int CheckEmp = random.Next(0,2);
            if (CheckEmp == Is_Present)
            {
                Console.WriteLine("Employee is Present");
                 EmpHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                 EmpHrs = 0;
            }
            int wage = Emp_Rate_Per_Hrs * EmpHrs;
            Console.WriteLine("Employee Daily Wage: {0}",wage);
        }
       
        

    }
}
