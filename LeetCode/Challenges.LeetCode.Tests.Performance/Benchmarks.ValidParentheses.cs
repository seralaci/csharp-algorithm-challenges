using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.ValidParentheses;

namespace Challenges.LeetCode.Tests.Performance;

public class ValidParentheses : BenchmarkBase
{
    public string[] X { get; set; }

    [Benchmark(Description = "ValidParentheses.StackBased")]
    public bool StackBased()
    {
        var solution = new StackBased();
        return solution.IsValid(_input);
    }

    private readonly string _input = "{([]{})}";
}