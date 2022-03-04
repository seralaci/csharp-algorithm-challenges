using System;

/*
 * Problem description:
 *
 * Write a function to find the longest common prefix string amongst an array of strings.
 * If there is no common prefix, return an empty string "".
 *
 * Example 1:
 * Input: ["flower","flow","flight"]
 * Output: "fl"
 *
 * Example 2:
 * Input: ["dog","racecar","car"]
 * Output: ""
 * Explanation: There is no common prefix among the input strings.
 *
 * Note:
 * All given inputs are in lowercase letters a-z.
 */

namespace Challenges.LeetCode.LongestCommonPrefix;

public class SortedByLength
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return string.Empty;
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }

        Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));

        for (var i = 0; i < strs[0].Length; i++)
        {
            var character = strs[0][i];
            for (var j = 1; j < strs.Length; j++)
            {
                if (strs[j].Length == i || character != strs[j][i])
                {
                    return strs[0].Substring(0, i);
                }                    
            }
        }

        return strs[0];
    }
}