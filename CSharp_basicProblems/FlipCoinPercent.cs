using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_basicProblems
{
    class FlipCoinPercent
    {
        Double[] flipCoinResult = new Double[2];
        public FlipCoinPercent(Double[] flipCoinResult)
        {
            for(int i = 0; i < flipCoinResult.Length; i++)
            {
                this.flipCoinResult[i] = flipCoinResult[i];
            }
        }

        public void FlipPercent()
        {
            Console.WriteLine("Percent of Heads: " + (flipCoinResult[1] / 10));
            Console.WriteLine("Percent of Tails: " + (flipCoinResult[0] / 10));
        }

    }
}
