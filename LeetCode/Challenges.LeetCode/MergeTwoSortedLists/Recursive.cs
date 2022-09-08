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

public class Recursive : ISolution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null)
        {
            return list2;
        }
        
        if (list2 is null)
        {
            return list1;
        } 
        
        if(list1.val <= list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }

        list2.next = MergeTwoLists(list1, list2.next);
        return list2;
    }
}