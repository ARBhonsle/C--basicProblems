using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_basicProblems
{
    class LargestNumber
    {
        int number, number1, number2;
        public LargestNumber(int number, int number1, int number2)
        {
            this.number = number;
            this.number1 = number1;
            this.number2 = number2;
        }
        public void FindLargest()
        {
            Console.WriteLine("Largest of given numbers: ");
            if (number > number1)
            {
                if (number > number2)
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine(number2);
                }
            }
            else
            {
                if (number1 > number2)
                {
                    Console.WriteLine(number1);
                }
                else
                {
                    Console.WriteLine(number2);
                }
            }
        }
    }
}
