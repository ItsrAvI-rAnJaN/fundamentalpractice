using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/t*****Welcome to Employee Wage Computation****");

            //create instance/object of class EmpWageComputatin
            EmpWageComputation objEmp = new EmpWageComputation();

            // Calling Method/Function define in class EmpWageComputatin
            objEmp.CalcEmpWage();


            Console.ReadKey();
        }
    }
}
