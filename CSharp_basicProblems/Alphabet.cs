using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_basicProblems
{
    class Alphabet
    {
        readonly Char value;
        public Alphabet(Char value)
        {
            this.value = Char.ToLower(value);
        }
        public void Check()
        {
            if( value =='a' || value =='e'|| value =='i'|| value =='o'||value == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }

        }
    }
}
