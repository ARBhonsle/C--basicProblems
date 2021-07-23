using System;

namespace CSharp_basicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Basic Problems");
            Console.WriteLine("Choose Problems: 1.Flip Coin Percent 2.Leap Year 3.Power of 2 ");
            Console.WriteLine("4.Harmonic Number 5.Factors 6.Finding Qoutient and Remainder");
            Console.WriteLine("7.Swap numbers 8.Even or Odd numbers 9.Alphabet Vowel/Consonant");
            int Choice = Convert.ToInt32(Console.ReadLine());
            int number,number1,number2;
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
                case 6:
                    Console.WriteLine("Finding Qoutient and Remainder");
                    Console.WriteLine("Give two numbers:");
                    Console.WriteLine("Divisor");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dividend");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    QoutientRemainder division = new QoutientRemainder(number1, number2);
                    division.Operation();
                    break;
                case 7:
                    Console.WriteLine("Swap numbers");
                    Console.WriteLine("Give two numbers:");
                    Console.WriteLine("Number1");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Number2");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    SwapNumbers values = new SwapNumbers(number1, number2);
                    values.Swap();
                    break;
                case 8:
                    Console.WriteLine("Even or Odd numbers");
                    Console.WriteLine("Give number:");
                    number = Convert.ToInt32(Console.ReadLine());
                    EvenOdd result = new EvenOdd(number);
                    result.Operation();
                    break;
                case 9:
                    Console.WriteLine("Alphabet Vowel/Consonant");
                    Console.WriteLine("Give an alphabet:");
                    String character = Console.ReadLine();
                    Alphabet alphabet= new Alphabet(character.ToCharArray()[0]);
                    alphabet.Check();
                    break;
                default: 
                    Console.WriteLine("Wrong Input!!");
                    break;
            }
            
        }
    }
}
