using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.MergeTwoSortedLists;

namespace Challenges.LeetCode.Tests.Performance;

public class MergeTwoSortedLists : BenchmarkBase
{
    public MergeTwoSortedLists()
    {
        _firstList = ListNode.Create(new[] { 0, 1, 3, 5, 11, 13, 17 });
        _secondList = ListNode.Create(new[] { 2, 4, 6, 8, 10, 12, 20, 40, 60 });
    }
    
    [Benchmark(Description = "MergeTwoSortedLists.Iteration")]
    public ListNode Iteration()
    {
        var solution = new Iteration();
        return solution.MergeTwoLists(_firstList, _secondList);
    }      

    [Benchmark(Description = "MergeTwoSortedLists.Recursive")]
    public ListNode Recursive()
    {
        var solution = new Recursive();
        return solution.MergeTwoLists(_firstList, _secondList);
    }

    private readonly ListNode _firstList;
    private readonly ListNode _secondList;
}