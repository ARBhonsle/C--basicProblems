using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_basicProblems
{
    class LeapYear
    {
        readonly int year;
        public LeapYear(int year)
        {
            this.year = year;
        }
        public void CheckLeap()
        {
            if (year / 1000 > 0)
            {
                if ( (year % 4 == 0) && (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0) ) )
                {
                    Console.WriteLine("Year is Leap Year");
                }
                else
                {
                    Console.WriteLine("Year not Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Given year is not 4 digit");
            }
        }
    }
}
