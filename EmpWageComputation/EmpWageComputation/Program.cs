using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmpWageComputation objEmp = new EmpWageComputation();
            objEmp.EmpWagePartorFull();


            Console.ReadKey();
        }
    }
}
