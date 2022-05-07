using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpWageComputation
    {
        int Is_Part_Time =1;
        int Is_Full_Time = 2;
        int Emp_Rate_Per_Hrs = 20;


        int EmpHrs;
        
        Random random = new Random();
        
       
        public void EmpWagePartorFull()
        {
            int CheckEmp = random.Next(0,3);
            if (CheckEmp == Is_Full_Time)
            {
                Console.WriteLine("Full Time Employee");
                 EmpHrs = 8;
            }
            else if (CheckEmp == Is_Part_Time)
            {
                Console.WriteLine("Part Time Employee");
                 EmpHrs = 4;
            }
            else
            {
                EmpHrs = 0;
            }
            int wage = Emp_Rate_Per_Hrs * EmpHrs;
            Console.WriteLine("Employee Daily Wage: {0}",wage);
        }
       
        

    }
}
