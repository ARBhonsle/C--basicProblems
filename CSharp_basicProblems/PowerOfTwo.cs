using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_basicProblems
{
    class PowerOfTwo
    {
        readonly int number;
        public PowerOfTwo(int number)
        {
            this.number = number;
        }
        public void TableOfTwo()
        {
            int value=1;
            for(int i = 0; i <= this.number; i++)
            {
                Console.WriteLine("2^" + i + "=" + value);
                value *= 2;
            }
        }
    }
}
