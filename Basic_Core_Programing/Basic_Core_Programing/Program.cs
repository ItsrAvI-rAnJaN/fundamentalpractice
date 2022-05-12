using System;

namespace Basic_Core_Programing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Core Programming");

            // Creating Oject of FlipCoin Class
            FlipCoin objflipcoin = new FlipCoin();
            
            // Calling The Method or Funtion
             objflipcoin.CheckCoin();

            //To Hold The Output Terminal 
            Console.ReadKey(); 
        }
    }
}
