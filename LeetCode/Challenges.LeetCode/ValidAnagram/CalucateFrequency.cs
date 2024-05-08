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

public class CalucateFrequency
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        // Initializing frequency array
        var frequencies = new int[26];

        // Counting frequencies in s
        for (var i = 0; i < s.Length; i++)
        {
            frequencies[s[i] - 'a']++;
        }

        // Decrementing frequencies in t 
        for (var i = 0; i < t.Length; i++)
        {
            frequencies[t[i] - 'a']--;
        }

        // Checking if frequencies are zero
        foreach (var value in frequencies)
        {
            if (value != 0)
            {
                return false;
            }
        }

        return true;
    }
}
