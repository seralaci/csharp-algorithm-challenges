using System.Collections.Generic;
using Challenges.LeetCode.PalindromeNumber;
using Xunit;

namespace Challenges.LeetCode.Tests;

public class PalindromeNumberTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { 121, true };
        yield return new object[] { -121, false };
        yield return new object[] { 0, true };
        yield return new object[] { 10, false };
        yield return new object[] { 88, true };
        yield return new object[] { 12321, true };
        yield return new object[] { 123421, false };
        yield return new object[] { 1234210, false };
        yield return new object[] { 2147447412, true };
        yield return new object[] { int.MaxValue, false };
    }
       
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Reverse(int input, bool expectedResult)
    {
        // Arrange 
        var solution = new Reverse();

        // Act
        var result = solution.IsPalindrome(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void CompareLastAndFirst(int input, bool expectedResult)
    {
        // Arrange 
        var solution = new CompareLastAndFirst();

        // Act
        var result = solution.IsPalindrome(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}