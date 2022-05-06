using System;

namespace compLineComputation
{
     public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Line Comparision Computation");
                LineCompComputation objLine = new LineCompComputation();
                objLine.CalLineLength();
                objLine.ChkLIneLEnEqorNot();
                objLine.ChkLineLenGtorLt();
                Console.ReadKey();
            }
     }
}