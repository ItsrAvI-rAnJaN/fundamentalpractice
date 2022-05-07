using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class SnakeLadder
    {
        int Player_Postion=0;
        int Dice_Roll;
        Random random =new Random();
        
        // Method to define Player intial Start Position
        public void StartGame()
        {
            Console.WriteLine("The  Start Position of Player is {0}", Player_Postion);
        }

        // method to get Dice No. b/w 1 to 6
        public void DiceRoll()
        {
            Dice_Roll = random.Next(1, 7);
            Console.WriteLine("The Player rolls the Die & Get A Number is {0}",Dice_Roll);
        }

    }
}
