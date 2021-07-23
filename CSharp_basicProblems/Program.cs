using System;

namespace CSharp_basicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Basic Problems");
            Double[] flipResult = new Double[2];
            Console.WriteLine("Coin Flipped 10 times");
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                if (random.NextDouble() < 0.5)
                {
                    flipResult[0]++; //Tails
                }
                else
                {
                    flipResult[1]++; //Heads
                }
            }  
            FlipCoinPercent flip = new FlipCoinPercent(flipResult);
            flip.FlipPercent();
        }
    }
}
