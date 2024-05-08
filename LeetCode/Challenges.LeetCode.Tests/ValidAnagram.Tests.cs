using Xunit;
using Challenges.LeetCode.ValidAnagram;
using System.Collections.Generic;

namespace Challenges.LeetCode.Tests;

public class ValidAnagramTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { "anagram", "anagram", true };
        yield return new object[] { "anagram", "nagaram", true };
        yield return new object[] { "rat", "car", false };
        yield return new object[] { "a", "aa", false };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void BruteForce(string input, string target, bool expectedResult)
    {
        // Arrange 
        var solution = new BruteForce();

        // Act
        var result = solution.IsAnagram(input, target);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void SortedChars(string input, string target, bool expectedResult)
    {
        // Arrange 
        var solution = new SortedChars();

        // Act
        var result = solution.IsAnagram(input, target);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void CalucateFrequency(string input, string target, bool expectedResult)
    {
        // Arrange 
        var solution = new CalucateFrequency();

        // Act
        var result = solution.IsAnagram(input, target);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}
