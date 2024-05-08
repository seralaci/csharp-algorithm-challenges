using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.ValidAnagram;

namespace Challenges.LeetCode.Tests.Performance;

public class ValidAnagram : BenchmarkBase
{
    [Benchmark(Description = "ValidAnagram.BruteForce")]
    public bool BruteForce()
    {
        var solution = new BruteForce();
        return solution.IsAnagram(_source, _target);
    }

    [Benchmark(Description = "ValidAnagram.SortedChars")]
    public bool SortedChars()
    {
        var solution = new SortedChars();
        return solution.IsAnagram(_source, _target);
    }

    [Benchmark(Description = "ValidAnagram.CalucateFrequency")]
    public bool CalucateFrequency()
    {
        var solution = new CalucateFrequency();
        return solution.IsAnagram(_source, _target);
    }

    private readonly string _source = "anagram";
    private readonly string _target = "nagaram";
}
