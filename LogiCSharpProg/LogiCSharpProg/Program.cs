using System;

namespace LogiCSharpProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to C# Logical Programming*****\n ");
            FibonacciSeries objfibonacci = new FibonacciSeries();
            objfibonacci.calcFibonacciSeries();
            Console.ReadKey();
        }
    }
}