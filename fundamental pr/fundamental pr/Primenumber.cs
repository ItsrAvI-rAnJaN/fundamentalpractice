using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamental_pr
{
    public class Primenumber
    {
        public void Checkprime()
        {
            int Temp = 0;
            Console.Write("enter The Number Check Whether Prime Number or Not : ");
            int Number =Convert .ToInt32(Console.ReadLine());
            if (Number > 0)
            {
                for(int i = 2; i < Number/2; i++)
                {
                    if(Number % 2 == 0)
                    {
                        Temp = 1;
                        break;
                    }

                }
                if (Temp == 0)
                {
                    Console.WriteLine(" The Number You Enter is Not a Prime Number");
                }
                else
                {
                    Console.WriteLine("The Number You Enter is Not a Prime Number");
                }

            }

        }
    }
}
