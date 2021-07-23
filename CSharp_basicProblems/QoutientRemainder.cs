using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_basicProblems
{
    class QoutientRemainder
    {
        int[] number = new int[2];
        public QoutientRemainder(int number1,int number2)
        {
            number[0] = number1;
            number[1] = number2;
        }
        public void Operation()
        {
            Console.WriteLine("Division Operation");
            Console.WriteLine("Divisor " + number[0] + " and dividend " + number[1]);
            Console.WriteLine("Quotient "+(number[1]/number[0])+" and Remainder " +(number[1]%number[0]));
        }
    }
}
