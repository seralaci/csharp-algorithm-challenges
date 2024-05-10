using System.Collections.Generic;
using Challenges.LeetCode.KthLargestElement;
using Xunit;

namespace Challenges.LeetCode.Tests;

public class KthLargestElementTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new[] { 3, 2, 1, 5, 6, 4 }, 2, 5 };
        yield return new object[] { new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, 4 };
        yield return new object[] { new[] { 4, 2, 9, 7, 5, 6, 7, 1, 3 }, 4, 6 };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Sorting(int[] nums, int k, int output)
    {
        // Arrange 
        var solution = new Sorting();

        // Act
        var result = solution.FindKthLargest(nums, k);

        // Assert
        Assert.Equal(output, result);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void RemoveMax(int[] nums, int k, int output)
    {
        // Arrange 
        var solution = new RemoveMax();

        // Act
        var result = solution.FindKthLargest(nums, k);

        // Assert
        Assert.Equal(output, result);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void PriorityQueue(int[] nums, int k, int output)
    {
        // Arrange 
        var solution = new PriorityQueue();

        // Act
        var result = solution.FindKthLargest(nums, k);

        // Assert
        Assert.Equal(output, result);
    }    
}
