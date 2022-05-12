using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programing
{
    public class FlipCoin
    {
        public void CheckCoin()
        {
            int Result;
            int Heads = 0;      // Taking Variable 
            int Tails = 0;
            Random CoinFLip = new Random();   

            // Taking Input
            Console.Write("Enter The Number of Times to Flip Coin:");
            int NoOfFlip =Convert.ToInt32(Console.ReadLine());



            // Defining Logic
            for (int i = 0; i < NoOfFlip; i++) 
            {
                Result= CoinFLip.Next(0,2);
                if(Result < 0.5)
                {
                    Tails++;
                }
                else
                {
                    Heads++;
                }
            }
            Console.WriteLine("Number of Head : {0}",Heads);
            Console.WriteLine("Number of Tails : {0}",Tails);

            float PerOfHeads = (float)Heads / (float)NoOfFlip * 100;
            float PerOfTails = (float)Tails / (float)NoOfFlip * 100;

            // printing Output 
            Console.WriteLine("Percantange of Head is {0}% & Percantage of Tails is {1}",PerOfHeads,PerOfTails);

        }

    }
}
