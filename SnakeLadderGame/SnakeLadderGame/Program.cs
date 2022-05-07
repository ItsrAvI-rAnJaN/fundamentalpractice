using System;

namespace SnakeLadderGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game");
            SnakeLadder ObjGame= new SnakeLadder();
            ObjGame.StartGame();
            ObjGame.DiceRoll();
            Console.ReadKey();
        }
    }
}
