using System;
using System.Collections.Generic;
using Xunit;
using Challenges.LeetCode.FirstLastPosition; 

namespace Challenges.LeetCode.Tests;

public class FirstLastPositionTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 } };
        yield return new object[] { new[] { 5, 7, 7, 8, 8, 10, 11 }, 8, new[] { 3, 4 } };
        yield return new object[] { new[] { 2, 4, 5, 5, 5, 5, 5, 7, 9, 9 }, 5, new[] { 2, 6 } };
        yield return new object[] { new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 } };
        yield return new object[] { new[] { 1 }, 1, new[] { 0, 0 } };
        yield return new object[] { Array.Empty<int>(), 0, new[] { -1, -1 } };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void BruteForce(int[] nums, int target, int[] output)
    {
        // Arrange 
        var solution = new BruteForce();

        // Act
        var result = solution.SearchRange(nums, target);

        // Assert
        Assert.Equal(output, result);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void BinarySearch(int[] nums, int target, int[] output)
    {
        // Arrange 
        var solution = new BinarySearch();

        // Act
        var result = solution.SearchRange(nums, target);

        // Assert
        Assert.Equal(output, result);
    }
}
