/*
 * Problem description:
 *
 * You are given the heads of two sorted linked lists list1 and list2.
 * 
 * Merge the two lists in a one sorted list.
 * The list should be made by splicing together the nodes of the first two lists.
 *
 * Return the head of the merged linked list.
 */

namespace Challenges.LeetCode.MergeTwoSortedLists;

public class Iteration : ISolution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null && list2 is null)
            return null;

        var root = new ListNode();
        var current = root;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }
        
        current.next = list1 ?? list2;
        
        return root.next;
    }
}