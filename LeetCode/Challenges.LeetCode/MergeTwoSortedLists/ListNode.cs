namespace Challenges.LeetCode.MergeTwoSortedLists;

public class ListNode
{
    public int val;

    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
    
    public static ListNode Create(int[] values)
    {
        if (values == null || values.Length == 0)
            return null;

        var headNode = new ListNode(values[^1]);
        if (values.Length == 1) 
            return headNode;
        
        for (var i = values.Length - 2; i >= 0; i--)
        {
            headNode = new ListNode(values[i], headNode);
        }

        return headNode;
    }
}