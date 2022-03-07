using System.Collections.Generic;
using Challenges.LeetCode.ValidParentheses;
using Xunit;

namespace Challenges.LeetCode.Tests;

public class ValidParenthesesTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { "()", true };
        yield return new object[] { "((", false };
        yield return new object[] { "()[]{}", true};
        yield return new object[] { "(]", false };
        yield return new object[] { "([)]", false };
        yield return new object[] { "{[]}", true};
        yield return new object[] { "(())", true };
        yield return new object[] { "([])", true };
        yield return new object[] { "([]{})", true };
        yield return new object[] { "([]{])", false };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void StackBased(string input, bool expected)
    {
        // Arrange 
        var solution = new StackBased();

        //Assert
        var result = solution.IsValid(input);

        //Assert
        Assert.Equal(expected, result);
    }
}