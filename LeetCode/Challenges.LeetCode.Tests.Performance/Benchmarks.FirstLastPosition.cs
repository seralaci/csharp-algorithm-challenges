using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.FirstLastPosition;

namespace Challenges.LeetCode.Tests.Performance;

public class FirstLastPosition : BenchmarkBase
{
    [Benchmark(Description = "FirstLastPosition.BruteForce")]
    public int[] BruteForce()
    {
        var solution = new BruteForce();
        return solution.SearchRange(_source, _target);
    }

    [Benchmark(Description = "FirstLastPosition.BinarySearch")]
    public int[] BinarySearch()
    {
        var solution = new BinarySearch();
        return solution.SearchRange(_source, _target);
    }

    private readonly int[] _source = new[] { 2, 4, 5, 5, 5, 5, 5, 7, 9, 9 };
    private readonly int _target = 5;
}
