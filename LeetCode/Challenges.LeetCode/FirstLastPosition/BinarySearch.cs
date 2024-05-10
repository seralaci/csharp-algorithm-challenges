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

public class BinarySearch
{
    /*
     * Time complexity : O(log n)
     * Space complexity : O(1)
     */
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return CreateResult(-1, -1);
        }

        var first = FindFirst(nums, target);
        var last = FindLast(nums, target);

        return CreateResult(first, last);
    }

    private static int FindFirst(int[] nums, int target)
    {       
        if (nums[0] == target)
        {
            return 0;
        }

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            var middle = (left + right) / 2;

            if (nums[middle] == target && nums[middle - 1] < target)
            {
                return middle;
            }

            if (nums[middle] < target)
            {
                left = middle + 1;
            }
            else
            {              
                right = middle - 1;
            }           
        }

        return -1;
    }

    private static int FindLast(int[] nums, int target)
    {       
        int right = nums.Length - 1;   
       
        if (nums[right] == target)
        {
            return right;
        }

        int left = 0;

        while (left <= right)
        {
            var middle = (left + right) / 2;

            if (nums[middle] == target && nums[middle + 1] > target)
            {
                return middle;
            }

            if (nums[middle] > target)
            {
                right = middle - 1;
            }
            else
            {               
                left = middle + 1;
            }
        }

        return -1;
    }

    private static int[] CreateResult(int first, int last) => new[] { first, last };
}
