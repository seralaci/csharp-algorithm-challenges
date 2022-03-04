using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.PalindromeNumber;

namespace Challenges.LeetCode.Tests.Performance;

public class PalindromeNumber : BenchmarkBase
{
    [Params(789544123, 12321, int.MaxValue)]
    public int X { get; set; }

    [Benchmark(Description = "PalindromeNumber.Reverse")]
    public bool Reverse()
    {
        var solution = new Reverse();
        return solution.IsPalindrome(X);
    }

    [Benchmark(Description = "PalindromeNumber.CompareLastAndFirst")]
    public bool CompareLastAndFirst()
    {
        var solution = new CompareLastAndFirst();
        return solution.IsPalindrome(X);
    }
}