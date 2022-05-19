using System;

namespace fundamental_pr
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t*******Welcome to Fundamental Programming******");
            Console.WriteLine("Q1. Check Prime Number or Not");
            Console.WriteLine(" Enter The Number Question");
            int Choice=Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Primenumber objcheckprime = new Primenumber();
                    objcheckprime.Checkprime();
                    break;
                default:
                    Console.WriteLine("invalid Input");
                    break;

            }
            Console.ReadKey();
        }
    }
}