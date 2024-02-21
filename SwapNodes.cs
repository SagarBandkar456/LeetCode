using System;

class SwapNodes
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null) return head;

        ListNode second = head.next;
        ListNode third = second.next;

        second.next = head;
        head.next = SwapPairs(third);

        return second;
    }
}