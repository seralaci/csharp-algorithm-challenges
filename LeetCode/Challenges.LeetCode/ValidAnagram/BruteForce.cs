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

namespace Challenges.LeetCode.ValidAnagram;

public class BruteForce
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var visited = new bool[t.Length];
        for (var i = 0; i < s.Length; i++)
        {
            var found = false;

            for (var j = 0; j < t.Length; j++)
            {
                if (s[i] == t[j] && !visited[j])
                {
                    found = true;
                    visited[j] = true;
                    break;
                }
            }

            if (!found)
            {
                return false;
            }
        }

        return true;
    }
}
