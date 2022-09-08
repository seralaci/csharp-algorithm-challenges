using System.Collections.Generic;
using Challenges.LeetCode.TwoSum;
using Xunit;

namespace Challenges.LeetCode.Tests;

public class TwoSumTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new[] { 2, 3, 5, 6, 10, 12, 3 }, 11, new[] { 2, 3 } };
        yield return new object[] { new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 } };
        yield return new object[] { new[] { 18, 2, 3, 24, 66, 48, 52, 10, 40, 12, 5, 6 }, 11, new[] { 10, 11 } };
        yield return new object[] { new[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 }, 542, new[] { 28, 45 } };
    }
    
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void BruteForce(int[] input, int target, int[] output)
    {
        // Arrange 
        var solution = new BruteForce();

        // Act
        var result = solution.TwoSum(input, target);

        // Assert
        Assert.Equal(output, result);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void OnePassDictionary(int[] input, int target, int[] output)
    {
        // Arrange 
        var solution = new OnePassDictionary();

        // Act
        var result = solution.TwoSum(input, target);

        // Assert
        Assert.Equal(output, result);
    }
}