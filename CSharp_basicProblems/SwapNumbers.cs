using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_basicProblems
{
    class SwapNumbers
    {
        int number1, number2;
        public SwapNumbers(int number1,int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public void Swap()
        {
            Console.WriteLine("Before Swap: Number1= " + number1 + " Number2= " + number2);
            number1 += number2;
            number2 = number1 - number2;
            number1 = number1- number2;
            Console.WriteLine("After Swap: Number1= " + number1 + " Number2= " + number2);
        }
    }
}
