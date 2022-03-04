using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.ReverseInteger;

namespace Challenges.LeetCode.Tests.Performance;

public class ReverseInteger : BenchmarkBase
{
    [Params(789544123, 123, int.MinValue)]
    public int X { get; set; }

    [Benchmark(Description = "ReverseInteger.Solution")]
    public int Solution()
    {
        var solution = new Solution();
        return solution.Reverse(X);
    }
}