namespace Challenges.LeetCode.FirstLastPosition;

/*
 * Problem description:
 *
 * Given an array of integers `nums` sorted in non-decreasing order, find the starting and ending position of a given `target` value.
 * 
 * If `target` is not found in the array, return `[-1, -1]`.
 * 
 * You must write an algorithm with `O(log n)` runtime complexity.
 * 
 * Example 1:
 *    Input: `nums = [5,7,7,8,8,10], target = 8`  
 *    Output: `[3,4]`
 *    
 * Example 2:
 *   Input: `nums = [5,7,7,8,8,10], target = 6`  
 *   Output: `[-1,-1]`
 *   
 * Example 3:
 *   Input: `nums = [], target = 0`  
 *   Output: `[-1,-1]`
 *   
 * Constraints:
 *   - 0 <= nums.length <= 10<sup>5</sup>
 *   - -10<sup>9</sup> <= nums[i] <= 10<sup>9</sup>
 *   - `nums` is a non-decreasing array.
 *   - -10<sup>9</sup> <= target <= 10<sup>9</sup>
 */

public class BruteForce
{
    /*
     * Time complexity : O(n)
     * Space complexity : O(1)
     */
    public int[] SearchRange(int[] nums, int target)
    {
        var first = -1;
        var last = -1;

        if (nums.Length == 0)
        {
            return CreateResult(first, last);
        }

        for (var i = 0; i < nums.Length; i++)
        {
            // Since the array is sorted, if the current element is smaller than the target, then let's move on
            if (nums[i] < target)
            {
                continue;
            }

            // If the value of the current element is greater, then there is no point in proceeding further
            if (nums[i] > target)
            {
                break;
            }

            // Remember the index of the first element, which was the same as the target value
            if (first == -1)
            {
                first = i;
            }

            // Remember the index of the last element, which was the same as the target value
            last = i;
        }


        return CreateResult(first, last);
    }

    private static int[] CreateResult(int first, int last) => new[] { first, last };
}
