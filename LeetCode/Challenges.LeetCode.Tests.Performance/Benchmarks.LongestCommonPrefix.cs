using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.LongestCommonPrefix;

namespace Challenges.LeetCode.Tests.Performance;

public class LongestCommonPrefix : BenchmarkBase
{
    public string[] X { get; set; }

    [Benchmark(Description = "LongestCommonPrefix.BruteForce")]
    public string BruteForce()
    {
        var solution = new BruteForce();
        return solution.LongestCommonPrefix(_input);
    }

    [Benchmark(Description = "LongestCommonPrefix.SortedByLength")]
    public string SortedByLength()
    {
        var solution = new SortedByLength();
        return solution.LongestCommonPrefix(_input);
    }

    private readonly string[] _input = { "flower", "flow", "flight" };
}