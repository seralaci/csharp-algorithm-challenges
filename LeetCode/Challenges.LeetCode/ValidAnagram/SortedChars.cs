/*
 * Problem description:
 *
 * Given two strings s and t, return true if t is an anagram of s,and false otherwise.
 * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
 *
 * Example 1:
 *  Input: s = "anagram", t = "nagaram"
 *  Output: true
 *  
 * Example 2:
 *  Input: s = "rat", t = "car"
 *  Output: false
 *  
 * Constraints:
 * - 1 <= s.length, t.length <= 5 * 10 pow 4
 * - s and t consist of lowercase English letters.
 */

using System;
using System.Linq;

namespace Challenges.LeetCode.ValidAnagram;

public class SortedChars
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var sourceArray = s.ToCharArray();
        var targetArray = t.ToCharArray();

        Array.Sort(sourceArray);
        Array.Sort(targetArray);

        return sourceArray.SequenceEqual(targetArray);
    }
}
