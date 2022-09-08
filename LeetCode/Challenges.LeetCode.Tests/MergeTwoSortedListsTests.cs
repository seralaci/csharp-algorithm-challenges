using System;
using System.Collections.Generic;
using Challenges.LeetCode.MergeTwoSortedLists;
using Xunit;

namespace Challenges.LeetCode.Tests;

public class MergeTwoSortedListsTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 } };
        yield return new object[] { Array.Empty<int>(), Array.Empty<int>(), Array.Empty<int>() };
        yield return new object[] { Array.Empty<int>(), new[] { 0 }, new[] { 0 } };
        yield return new object[] { new[] { 0, 1, 3, 5 }, new[] { 2, 4, 6 }, new[] { 0, 1, 2, 3, 4, 5, 6 } };
        yield return new object[] { new[] { 2, 4, 6 }, new[] { 0, 1, 3, 5 }, new[] { 0, 1, 2, 3, 4, 5, 6 } };
    }
    
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Iteration(int[] firstList, int[] secondList, int[] expected)
    {
        // Arrange 
        var solution = new Iteration();

        // Act
        // Assert
        ActAndAssert(solution, firstList, secondList, expected);
    }
    
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Recursive(int[] firstList, int[] secondList, int[] expected)
    {
        // Arrange 
        var solution = new Recursive();

        // Act
        // Assert
        ActAndAssert(solution, firstList, secondList, expected);
    }
    
    private void ActAndAssert(ISolution solution, int[] firstList, int[] secondList, int[] expected)
    {
        // Arrange 
        var firstListNode = ListNode.Create(firstList);
        var secondListNode = ListNode.Create(secondList);
        var expectedListNode = ListNode.Create(expected);
     
        //Assert
        var result = solution.MergeTwoLists(firstListNode, secondListNode);

        //Assert
        if (expectedListNode is null)
        {
            Assert.Null(result);
        }
        else
        {
            Assert.NotNull(result);
            Assert.True(IdenticalListNodes(result, expectedListNode));
        }
    }

    private static bool IdenticalListNodes(ListNode firstHead, ListNode secondHead)
    {
        var a = firstHead;
        var b = secondHead;
        
        while (a != null && b != null)
        {
            if (a.val != b.val)
                return false;
            
            a = a.next;
            b = b.next;
        }
        
        return a == null && b == null;
    }
}