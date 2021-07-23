using System;

namespace CSharp_basicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Basic Problems");
            Console.WriteLine("Choose Problems: 1.Flip Coin Percent 2.Leap Year 3.Power of 2 4.Harmonic Number 5.Factors");
            int Choice = Convert.ToInt32(Console.ReadLine());
            int number;
            switch (Choice)
            {
                case 1:
                    Double[] flipResult = new Double[2];
                    Console.WriteLine("Coin Flipped 10 times");
                    Random random = new Random();
                    for (int i = 0; i < 10; i++)
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
                    break;
                case 2:
                    Console.WriteLine("Leap Year Problem");
                    Console.WriteLine("Input a year:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    LeapYear leapYear = new LeapYear(year);
                    leapYear.CheckLeap();
                    break;
                case 3:
                    Console.WriteLine("Power of 2");
                    Console.WriteLine("Give number n<31");
                    number = Convert.ToInt32(Console.ReadLine());
                    PowerOfTwo table = new PowerOfTwo(number);
                    table.TableOfTwo();
                    break;
                case 4:
                    Console.WriteLine("Harmonic Number");
                    Console.WriteLine("Give number (integer>0):");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0)
                    {
                        HarmonicNumber series = new HarmonicNumber(number);
                        series.NumberProgression();
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }
                    break;
                case 5:
                    Console.WriteLine("Factors of Number");
                    Console.WriteLine("Give number (integer):");
                    number = Convert.ToInt32(Console.ReadLine());
                    Factors prime = new Factors(number);
                    prime.PrimeFactors();
                    break;
                default: 
                    Console.WriteLine("Wrong Input!!");
                    break;
            }
            
        }
    }
}
