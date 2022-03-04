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

public class Reverse
{
    /*
     * Revert the second half of original number and then compare to the first half original number.
     * If they are the same, then the original number is a palindrome.
     *
     * If the number of digits in the original number is odd, then don't worry about the middle digit
     * (eg. 123_4_321 -> 4 doesn't matter).
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

        var reversed = 0;
        while (x > reversed)
        {
            // get the last digit + shift left revesed by 1 digit
            reversed = x % 10 + reversed * 10; 
            // remove the last digit
            x /= 10; 
        }

        // Number of digits in original x:
        // - Even number: if x and reversed are equal, then the original x is a palindrome.
        // - Odd number: if x and reversed / 10 (since the last digit doesn't matter) are equal, then the original x is a palindrome.
        return x == reversed || x == reversed / 10;
    }
}