using System;
using System.Net;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading students numbers:");

            ScoreCalculator sc = new ScoreCalculator();

            sc.Calculate();
            
            Console.WriteLine("Finished ...");
            Console.ReadKey();
        }
    }
}