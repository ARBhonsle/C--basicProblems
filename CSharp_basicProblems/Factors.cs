using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_basicProblems
{
    class Factors
    {
        int number;
        public Factors(int number)
        {
            this.number = number;
        }
        public void PrimeFactors()
        {
            for(int i = 2; i <= number; )
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
