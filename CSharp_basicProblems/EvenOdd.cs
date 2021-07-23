using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_basicProblems
{
    class EvenOdd
    {
        int number;
        public EvenOdd(int number)
        {
            this.number = number;
        }
        public void Operation()
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
