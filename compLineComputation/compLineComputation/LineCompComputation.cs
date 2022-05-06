using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compLineComputation
{
    public class LineCompComputation
    {
        double Linelength1;
        public void CalLineLength()
        {
            // Coordinate of Line1
            Console.Write(" Please Enter The Point 1 Coordinate X1:- ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 1 Coordinate X2:- ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y1:- ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y2:- ");
            int Y2 = Convert.ToInt32(Console.ReadLine());
           

            double LengthLine1 = Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2);
            Linelength1 = Math.Sqrt(LengthLine1);
            // length of line 1
            Console.WriteLine("length of Line1 is {0}  ", Linelength1);
        }

       


    }
}
