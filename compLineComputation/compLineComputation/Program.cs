using System;

namespace compLineComputation
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cartesian Coordinate  Line Comparision Computation");
            LineCompComputation objLine = new LineCompComputation();
            objLine.CalLineLength();

            Console.ReadKey();
        }
    }
}