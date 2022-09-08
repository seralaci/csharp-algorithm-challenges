using System.Collections.Generic;
using Challenges.LeetCode.LongestCommonPrefix;
using Xunit;

namespace Challenges.LeetCode.Tests;

public class LongestCommonPrefixTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new[] { "" }, "" };
        yield return new object[] { new[] { "a" }, "a" };
        yield return new object[] { new[] { "a", "a" }, "a" };
        yield return new object[] { new[] { "aca", "cba" }, "" };
        yield return new object[] { new[] { "flower", "flow", "flight" }, "fl" };
        yield return new object[] { new[] { "dog", "racecar", "car" }, "" };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void BruteForce(string[] input, string output)
    {
        // Arrange 
        var solution = new BruteForce();

        // Act
        var result = solution.LongestCommonPrefix(input);

        // Assert
        Assert.Equal(output, result);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void SortedByLength(string[] input, string output)
    {
        // Arrange 
        var solution = new SortedByLength();

        // Act
        var result = solution.LongestCommonPrefix(input);

        // Assert
        Assert.Equal(output, result);
    }
}