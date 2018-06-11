using System;

namespace Challenges.LeetCode.ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            if (x > -10 && x < 10)
            {
                return x;
            }

            var reversed = 0;
            while (x != 0)
            {
                try
                {
                    // use checked keyword to enable overflow checking
                    // (By default, the overflow in doesn't cause a run-time exception)
                    checked
                    {
                        // get the last digit + shift left revesed by 1 digit
                        reversed = x % 10 + reversed * 10;
                    }
                }
                catch (OverflowException)
                {
                    return 0;
                }

                // remove the last digit
                x /= 10;
            }

            return reversed;
        }
    }
}
