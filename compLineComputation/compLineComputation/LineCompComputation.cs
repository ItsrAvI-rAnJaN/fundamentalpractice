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
        double LineLength2;
        public void CalLineLength()
        {
            // coordinate of Line1
            Console.Write(" Please Enter The Point 1 Coordinate X1:- ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 1 Coordinate X2:- ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y1:- ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y2:- ");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            // coordinate of line 2
            Console.Write(" Please Enter The Point 1 Coordinate X3:- ");
            int X3 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 1 Coordinate X4:- ");
            int X4 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y3:- ");
            int Y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y4:- ");
            int Y4 = Convert.ToInt32(Console.ReadLine());

            double LengthLine1 = Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2);
            // length of line1
            Linelength1 = Math.Sqrt(LengthLine1);
            double LengthLine2 = Math.Pow(X4 - X3, 2) + Math.Pow(Y4 - Y3, 2);
            // Length of Line2
            LineLength2 = Math.Sqrt(LengthLine2);
            Console.WriteLine("length of Line1 is {0} & Length of line is {1} ", Linelength1, LineLength2);
        }

        // Method to Check Length of Line is Equal or Not
        public void ChkLIneLEnEqorNot()
        {
            if (Linelength1 == LineLength2)
            {
                Console.WriteLine("Length of Line1 & length of Line is Equal");
            }
            else
            {
                Console.WriteLine("Length of Line1 & Length Of Line is Not Equal");
            }
        }
        // Method to check which Length of Line is Greater
        public void ChkLineLenGtorLt()
        {
            if(Linelength1 > LineLength2)
            {
                Console.Write("Length of Line1 is Greater than Length of Line2");

            }
            else
            {
                Console.WriteLine("Length of Line2 is Greater than Length of Line1");
            }
        }


    }
}
