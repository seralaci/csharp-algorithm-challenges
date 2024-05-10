using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.KthLargestElement;

namespace Challenges.LeetCode.Tests.Performance;

public class KthLargestElement : BenchmarkBase
{
    [Benchmark(Description = "KthLargestElement.Sorting")]
    public int BruteForce()
    {
        var solution = new Sorting();
        return solution.FindKthLargest(_nums, _k);
    }

    [Benchmark(Description = "KthLargestElement.RemoveMax")]
    public int RemoveMax()
    {
        var solution = new RemoveMax();
        return solution.FindKthLargest(_nums, _k);
    }

    [Benchmark(Description = "KthLargestElement.PriorityQueue")]
    public int PriorityQueue()
    {
        var solution = new PriorityQueue();
        return solution.FindKthLargest(_nums, _k);
    }

    private readonly int[] _nums = new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
    private readonly int _k = 4;
}
