using System;

/*
 * Problem description:
 *
 * Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
 * 
 * Example 1:
 * 
 * Input: 121
 * Output: true
 * Example 2:
 * 
 * Input: -121
 * Output: false
 * Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
 * Example 3:
 * 
 * Input: 10
 * Output: false
 * Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 *
 * Follow up:
 * 
 * Coud you solve it without converting the integer to a string?
 *
 */
namespace Challenges.LeetCode.PalindromeNumber;

public class CompareLastAndFirst
{
    /*
     * Get the first and last digit of the number. If they aren't the same, then the original number isn't a palindrome. 
     * If they are the same, then remove the first and last digit from the number and compare again the first and last digits.
     * We continue this as long as we run out of the digits, then the original number is a palindrome. 
     *
     */
    public bool IsPalindrome(int x)
    {
        // 0 is a palindrome number.
        if (x == 0)
        {
            return true;
        }

        // None of the negative numbers are palindromic.
        // If the last digit is 0 (and the number isn't 0) then x is not a palindrome.
        if (x < 0 || x % 10 == 0)
        {
            return false;
        }

        // All numbers with one digit are palindromic.
        if (x < 10)
        {
            return true;
        }

        // the number of digits in x: largest integer less than or equal to log10(x) + 1
        var i = Math.Floor(Math.Log10(x));
        while (i >= 0)
        {
            var tenPowers = (int)Math.Pow(10, i);

            var firstDigit = x / tenPowers;
            var lastDigit = x % 10;
                
            if (firstDigit != lastDigit)
            {
                return false;
            }

            // remove the first digit
            x = x % tenPowers; 
            // remove the last digit
            x /= 10; 

            i -= 2;
        }

        return true;
    }
}