using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_basicProblems
{
    class HarmonicNumber
    {
        readonly int number;
        Double sum;
        public HarmonicNumber(int number)
        {
            this.number = number;
            sum = 0;
        }
        public void NumberProgression()
        {
            for(int i = 0; i < number; )
            {
                Console.Write("1/" + ++i);
                sum += Math.Pow(i,-1);
                if (i != number) Console.Write(" + ");
                else Console.Write(" = ");
            }
            Console.WriteLine(sum);
        }
    }
}
