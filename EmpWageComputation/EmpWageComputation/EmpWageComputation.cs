using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpWageComputation
    {
        int Is_Present = 1;
        public void CheckEmpPresentorNot()
        {
            Random random = new Random();
            int CheckEmp =random.Next(0,2);
            if (CheckEmp == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
