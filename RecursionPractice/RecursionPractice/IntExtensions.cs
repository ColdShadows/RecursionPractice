using System;
using System.Runtime.CompilerServices;

namespace RecursionPractice
{
    public static class IntExtensions
    {
        public static int GetPowerOf(this int number, int power)
        {
            //Exit Condition
            if(power == 0)
            {
                return 1;
            }
            //Exit Condition
            if (power == 1)
            {
                return number;
            }

            return number * GetPowerOf(number, power - 1);
        }
        
    }
}
