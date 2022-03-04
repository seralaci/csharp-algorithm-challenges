using System;
using System.Collections.Generic;

/*
 * Problem description:
 *
 * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 *
 * Example:
 * Given nums = [2, 7, 11, 15], target = 9,
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
 */

namespace Challenges.LeetCode.TwoSum;

public class OnePassDictionary
{
    /*
     * Iterate and check if each element's complement (target - nums[i]) exists in a dictionary.
     * If it doesn't exist then insert the complement as a key and the index as a value to the dictionary.
     * Otherwise, we have found a solution and return immediately.
     *
     * Complexity Analysis:
     *
     * - Time complexity : O(n).
     *   We traverse the list containing nn elements only once. Each look up in the dictionary costs only O(1) time.
     *
     * - Space complexity : O(n).
     *   The extra space required depends on the number of items stored in the dictionary, which stores at most n elements.
     *
     */
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (map.TryGetValue(complement, out var otherIndex))
            {
                return new[] { otherIndex, i }; 
            }
            map[nums[i]]= i;
        }

        throw new ArgumentException("No two sum solution");
    }
}