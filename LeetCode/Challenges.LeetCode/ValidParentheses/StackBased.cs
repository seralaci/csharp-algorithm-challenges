using System.Collections.Generic;

/*
 * Problem description:
 *
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
 * determine if the input string is valid.
 *
 * An input string is valid if:
 *     1. Open brackets must be closed by the same type of brackets.
 *     2. Open brackets must be closed in the correct order.
 */

namespace Challenges.LeetCode.ValidParentheses;

public class StackBased
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return true;

        // Because the string can only contain brackets, if the length of the string is odd,
        // the incoming string is definitely not valid.
        if (s.Length % 2 != 0) 
            return false;

        var brackets = new Stack<char>();

        foreach (var character in s)
        {
            if (IsOpeningBracket(character))
            {
                brackets.Push(character);
                continue;
            }
            
            // If an open bracket has not preceded the closing, it is certainly not valid
            if (brackets.Count == 0)
                return false;

            var lastBracket = brackets.Pop();
            if (!IsMatchingBrackets(lastBracket, character))
                return false;
        }
        
        return brackets.Count == 0;
    }

    private static bool IsOpeningBracket(char character) =>
        character == '(' ||
        character == '{' ||
        character == '[';
    
    private static bool IsMatchingBrackets(char openingBracket, char closingBracket) =>
        openingBracket == '(' && closingBracket == ')' ||
        openingBracket == '{' && closingBracket == '}' ||
        openingBracket == '[' && closingBracket == ']';
}